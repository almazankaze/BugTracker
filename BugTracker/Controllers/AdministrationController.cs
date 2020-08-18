using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BugTracker.Models;
using BugTracker.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Logging;

namespace BugTracker.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdministrationController : Controller
    {
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly IProjectRepo projectRepo;
        private readonly IReportRepository reportRepository;
        private readonly ILogger<AccountController> logger;

        public AdministrationController(RoleManager<IdentityRole> roleManager, UserManager<ApplicationUser> userManager, 
            IReportRepository reportRepository, ILogger<AccountController> logger, IProjectRepo projectRepo)
        {
            this.roleManager = roleManager;
            this.userManager = userManager;
            this.reportRepository = reportRepository;
            this.projectRepo = projectRepo;
            this.logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> RolesList()
        {
            // get the roles of the app
            var adminRole = await roleManager.FindByNameAsync("Admin");
            var opRole = await roleManager.FindByNameAsync("Operations");

            // check to see that these roles exist
            if (adminRole == null || opRole == null)
            {
                ViewBag.ErrorMessage = $"Role Admin or Operations cannot be found";
                return View("NotFound");
            }

            // create view model
            var model = new RoleListViewModel()
            {
                AdminRoleID = adminRole.Id,
                OpRoleID = opRole.Id
            };

            // get current logged in user
            var loggedInUser = await userManager.GetUserAsync(HttpContext.User);

            // get list of users on same team
            var users = userManager.Users.Where(user => user.Organization == loggedInUser.Organization && user.TeamOwner == loggedInUser.TeamOwner).ToList();

            // assign users to a list
            foreach (var user in users)
            {
                // If the user is in this role, add the username to
                // AdminUsers or OpUsers of RoleListViewModel. This model
                // object is then passed to the view for display
                if (await userManager.IsInRoleAsync(user, adminRole.Name))
                {
                    model.AdminUsers.Add(user);
                }
                
                if(await userManager.IsInRoleAsync(user, opRole.Name))
                {
                    model.OpUsers.Add(user);
                }
            }


            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> ListUsers()
        {
            // get id of current logged in user
            var userId = userManager.GetUserId(HttpContext.User);

            // get info of the user
            var loggedInUser = await userManager.FindByIdAsync(userId);

            // only retrieve users of the same team
            var users = userManager.Users.Where(user => user.UserName != loggedInUser.UserName && user.Organization == loggedInUser.Organization && user.TeamOwner == loggedInUser.TeamOwner).ToList();
            return View(users);
        }

        [HttpGet]
        public async Task<IActionResult> EditUsersInRole(string id)
        {
            ViewBag.roleId = id;

            var role = await roleManager.FindByIdAsync(id);

            if (role == null)
            {
                ViewBag.ErrorMessage = $"Role with Id = {id} cannot be found";
                return View("NotFound");
            }

            var model = new List<UserRoleViewModel>();

            // get id of current logged in user
            var userId = userManager.GetUserId(HttpContext.User);

            // get info of the user
            var loggedInUser = await userManager.FindByIdAsync(userId);

            var users = userManager.Users.Where(user => user.UserName != loggedInUser.UserName && user.Organization == loggedInUser.Organization && user.TeamOwner == loggedInUser.TeamOwner).ToList();

            foreach (var user in users)
            {
                var userRoleViewModel = new UserRoleViewModel
                {
                    UserId = user.Id,
                    UserName = user.UserName
                };

                if (await userManager.IsInRoleAsync(user, role.Name))
                {
                    userRoleViewModel.IsSelected = true;
                }
                else
                {
                    userRoleViewModel.IsSelected = false;
                }

                model.Add(userRoleViewModel);
            }

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> EditUsersInRole(List<UserRoleViewModel> model, string id)
        {
            var role = await roleManager.FindByIdAsync(id);
            

            if (role == null)
            {
                ViewBag.ErrorMessage = $"Role with Id = {id} cannot be found";
                return View("NotFound");
            }

            for (int i = 0; i < model.Count; i++)
            {
                var user = await userManager.FindByIdAsync(model[i].UserId);

                IdentityResult result = null;

                if (model[i].IsSelected && !(await userManager.IsInRoleAsync(user, role.Name)))
                {
                    result = await userManager.AddToRoleAsync(user, role.Name);
                }
                else if (!model[i].IsSelected && await userManager.IsInRoleAsync(user, role.Name))
                {
                    result = await userManager.RemoveFromRoleAsync(user, role.Name);
                }
                else
                {
                    continue;
                }

                if (result.Succeeded)
                {
                    if (i < (model.Count - 1))
                        continue;
                    else
                        return RedirectToAction("roleslist");
                }
            }

            return RedirectToAction("roleslist");
        }

        public IActionResult AddUser()
        {
            return View();
        }

        [AcceptVerbs("Get", "Post")]
        public async Task<IActionResult> IsEmailInUse(string email)
        {
            var user = await userManager.FindByEmailAsync(email);

            if (user == null)
            {
                return Json(true);
            }
            else
            {
                return Json($"Email {email} is already in use.");
            }
        }

        [HttpPost]
        public async Task<IActionResult> AddUser(AddUserViewModel model)
        {
            if (ModelState.IsValid)
            {

                // get id of current logged in user
                var userId = userManager.GetUserId(HttpContext.User);

                // get info of the user
                var loggedInUser = await userManager.FindByIdAsync(userId);

                // Copy data from AddUserViewModel to IdentityUser
                var user = new ApplicationUser
                {
                    UserName = model.Email, // .Substring(0, model.Email.IndexOf('@')),
                    Email = model.Email,
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Organization = loggedInUser.Organization,
                    TeamOwner = loggedInUser.TeamOwner,
                    OrganizationId = loggedInUser.OrganizationId
                };

                // Store user data in AspNetUsers database table
                var result = await userManager.CreateAsync(user, model.Password);

                // If user is successfully created, redirect to list of users
                if (result.Succeeded)
                {

                    var token = await userManager.GenerateEmailConfirmationTokenAsync(user);

                    var confirmationLink = Url.Action("ConfirmEmail", "Account",
                        new { userId = user.Id, token = token }, Request.Scheme);

                    logger.Log(LogLevel.Warning, confirmationLink);

                    return RedirectToAction("listusers", "administration");
                }

                // If there are any errors, add them to the ModelState object
                // which will be displayed by the validation summary tag helper
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> DeleteUser(string id)
        {
            var user = await userManager.FindByIdAsync(id);

            if (user == null)
            {
                ViewBag.ErrorMessage = $"User with Id = {id} cannot be found";
                return View("NotFound");
            }
            else
            {
                var result = await userManager.DeleteAsync(user);

                if (result.Succeeded)
                {
                    return RedirectToAction("ListUsers");
                }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }

                return View("ListUsers");
            }
        }

        [HttpGet]
        public async Task<IActionResult> AssignBug(int id)
        {
            // store id of report
            ViewBag.reportId = id;

            // get id of current logged in user
            var userId = userManager.GetUserId(HttpContext.User);

            // get info of the user
            var loggedInUser = await userManager.FindByIdAsync(userId);

            var users = userManager.Users.Where(user => user.UserName != loggedInUser.UserName && user.Organization == loggedInUser.Organization && user.TeamOwner == loggedInUser.UserName).ToList();

            var model = new UserAssignViewModel();

            foreach (var user in users)
            {
                var teamMate = new TeamMate()
                {
                    UserId = user.Id,
                    UserName = user.UserName
                };

                model.TeamMates.Add(teamMate);
            }

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> AssignBug(UserAssignViewModel model, int id)
        {
            var bugReport = reportRepository.GetBugReport(id);


            if (bugReport == null)
            {
                ViewBag.ErrorMessage = $"Report with Id = {id} cannot be found";
                return View("NotFound");
            }

            // get selected user
            string selectedUserId = model.Selected;
            var user = await userManager.FindByIdAsync(selectedUserId);

            // if user does not exist
            if (user == null)
            {
                ViewBag.ErrorMessage = $"User with Id = {selectedUserId} cannot be found";
                return View("NotFound");
            }


            // assign bug to user
            bugReport.AssignedTo = user.FirstName +  " " + user.LastName;
            bugReport.AssignedToUserName = user.UserName;
            reportRepository.Update(bugReport);

            return RedirectToAction("update", "report", new { Id = id });
        }

        [HttpGet]
        public async Task<IActionResult> OpenBug(int id)
        {
            // get logged in user
            var user = await userManager.GetUserAsync(HttpContext.User);

            BugReport bugReport = reportRepository.GetBugReport(id);

            // check that user belongs to correct organization and can edit
            if (user.TeamOwner != bugReport.TeamOwner)
            {
                return View("NoAccess");
            }

            if (bugReport.Resolution == "Open")
            {
                ViewBag.ErrorTitle = $"Bug report is open";
                ViewBag.ErrorMessage = $"Bug with Id " + $"{bugReport.Id} is open. " +
                    $"No need to reopen";

                return View("Error");
            }

            ReopenViewModel model = new ReopenViewModel
            {
                Id = bugReport.Id
            };


            return View(model);
        }

        [HttpPost]
        public IActionResult OpenBug(ReopenViewModel model)
        {
            BugReport bugReport = reportRepository.GetBugReport(model.Id);
            bugReport.Status = "Created";
            bugReport.Resolution = "Open";
            bugReport.LastUpdate = DateTime.Now;

            // update report in database
            reportRepository.Update(bugReport);
            return RedirectToAction("issueDetails", "report", new { id = model.Id });
        }

        [HttpGet]
        public IActionResult CreateProject()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateProject(CreateProjectViewModel model)
        {
            if (ModelState.IsValid)
            {
                // get logged in user
                var user = await userManager.GetUserAsync(HttpContext.User);

                Project project = new Project
                {
                    Name = model.Name,
                    Description = model.Description.Replace("\n", "<br />"),
                    Created = DateTime.Now,
                    OrganizationId = user.OrganizationId
                };

                projectRepo.Add(project);
                return RedirectToAction("ProjectList");
            }

            return View();
        }

        [HttpGet]
        public async Task<IActionResult> ProjectList()
        {
            // get logged in user
            var user = await userManager.GetUserAsync(HttpContext.User);

            // get all projects in organization
            var projects = projectRepo.GetAllProjects(user.OrganizationId);

            return View(projects);
        }

        [HttpPost]
        public IActionResult DeleteProject(int id)
        {
            var project = projectRepo.Delete(id);

            if (project == null)
            {
                ViewBag.ErrorMessage = $"Project with Id = {id} cannot be found";
                return View("NotFound");
            }

            return RedirectToAction("ProjectList");
        }

        [HttpGet]
        public async Task<IActionResult> EditProject(int id)
        {

            // get logged in user
            var user = await userManager.GetUserAsync(HttpContext.User);

            // get project
            var project = projectRepo.GetProject(id);

            // check if user is in same organization is project
            if(user.OrganizationId != project.OrganizationId)
            {
                return View("NoAccess");
            }

            EditProjectViewModel model = new EditProjectViewModel
            {
                Id = project.Id,
                Name = project.Name,
                Description = project.Description
            };

            return View(model);
        }

        [HttpPost]
        public IActionResult EditProject(EditProjectViewModel model)
        {
            if(ModelState.IsValid)
            {
                // get project
                Project project = projectRepo.GetProject(model.Id);

                if(project == null)
                {
                    ViewBag.ErrorMessage = $"Project with Id = {model.Id} cannot be found and was not updated";
                    return View("NotFound");
                }

                project.Name = model.Name;
                project.Description = model.Description.Replace("\n", "<br />");

                // update project in database
                projectRepo.Update(project);

                return RedirectToAction("ProjectList");
            }

            return View();
        }
    }
}
