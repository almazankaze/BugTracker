using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BugTracker.Models;
using BugTracker.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace BugTracker.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdministrationController : Controller
    {
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly IReportRepository reportRepository;

        public AdministrationController(RoleManager<IdentityRole> roleManager, UserManager<ApplicationUser> userManager, IReportRepository reportRepository)
        {
            this.roleManager = roleManager;
            this.userManager = userManager;
            this.reportRepository = reportRepository;
        }

        [HttpGet]
        public IActionResult CreateRole()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateRole(CreateRoleViewModel model)
        {
            if (ModelState.IsValid)
            {
                // create a new role
                IdentityRole identityRole = new IdentityRole
                {
                    Name = model.RoleName
                };

                // Saves the role in the underlying AspNetRoles table
                IdentityResult result = await roleManager.CreateAsync(identityRole);

                if (result.Succeeded)
                {
                    return RedirectToAction("roleslist", "administration");
                }

                foreach (IdentityError error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }

            return View(model);
        }

        [HttpGet]
        public IActionResult RolesList()
        {
            var roles = roleManager.Roles;
            return View(roles);
        }

        [HttpGet]
        public async Task<IActionResult> ListUsers()
        {
            // get id of current logged in user
            var userId = userManager.GetUserId(HttpContext.User);

            // get info of the user
            var loggedInUser = await userManager.FindByIdAsync(userId);

            // only retrieve users of the same team
            var users = userManager.Users.Where(user => user.UserName != loggedInUser.UserName && user.Organization == loggedInUser.Organization && user.TeamOwner == loggedInUser.UserName).ToList();
            return View(users);
        }

        // Role ID is passed from the URL to the action
        [HttpGet]
        public async Task<IActionResult> EditRole(string id)
        {
            // Find the role by Role ID
            var role = await roleManager.FindByIdAsync(id);

            if (role == null)
            {
                ViewBag.ErrorMessage = $"Role with Id = {id} cannot be found";
                return View("NotFound");
            }

            var model = new EditRoleViewModel
            {
                Id = role.Id,
                RoleName = role.Name
            };

            // get id of current logged in user
            var userId = userManager.GetUserId(HttpContext.User);

            // get info of the user
            var loggedInUser = await userManager.FindByIdAsync(userId);

            var users = userManager.Users.Where(user => user.Organization == loggedInUser.Organization && user.TeamOwner == loggedInUser.UserName).ToList();

            // Retrieve all the Users
            foreach (var user in users)
            {
                // If the user is in this role, add the username to
                // Users property of EditRoleViewModel. This model
                // object is then passed to the view for display
                if (await userManager.IsInRoleAsync(user, role.Name))
                {
                    model.Users.Add(user.UserName);
                }
            }

            return View(model);
        }

        // This action responds to HttpPost and receives EditRoleViewModel
        [HttpPost]
        public async Task<IActionResult> EditRole(EditRoleViewModel model)
        {
            var role = await roleManager.FindByIdAsync(model.Id);

            if (role == null)
            {
                ViewBag.ErrorMessage = $"Role with Id = {model.Id} cannot be found";
                return View("NotFound");
            }
            else
            {
                role.Name = model.RoleName;

                // Update the Role using UpdateAsync
                var result = await roleManager.UpdateAsync(role);

                if (result.Succeeded)
                {
                    return RedirectToAction("roleslist");
                }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }

                return View(model);
            }
        }

        [HttpGet]
        public async Task<IActionResult> EditUsersInRole(string roleId)
        {
            ViewBag.roleId = roleId;

            var role = await roleManager.FindByIdAsync(roleId);

            if (role == null)
            {
                ViewBag.ErrorMessage = $"Role with Id = {roleId} cannot be found";
                return View("NotFound");
            }

            var model = new List<UserRoleViewModel>();

            // get id of current logged in user
            var userId = userManager.GetUserId(HttpContext.User);

            // get info of the user
            var loggedInUser = await userManager.FindByIdAsync(userId);

            var users = userManager.Users.Where(user => user.UserName != loggedInUser.UserName && user.Organization == loggedInUser.Organization && user.TeamOwner == loggedInUser.UserName).ToList();

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
        public async Task<IActionResult> EditUsersInRole(List<UserRoleViewModel> model, string roleId)
        {
            var role = await roleManager.FindByIdAsync(roleId);
            

            if (role == null)
            {
                ViewBag.ErrorMessage = $"Role with Id = {roleId} cannot be found";
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
                        return RedirectToAction("editrole", new { Id = roleId });
                }
            }

            return RedirectToAction("editrole", new { Id = roleId });
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
                    TeamOwner = loggedInUser.TeamOwner
                };

                // Store user data in AspNetUsers database table
                var result = await userManager.CreateAsync(user, model.Password);

                // If user is successfully created, redirect to list of users
                if (result.Succeeded)
                {
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
        public IActionResult AssignBug(int id)
        {
            // store id of report
            ViewBag.reportId = id;

            var model = new List<UserAssignViewModel>();

            foreach (var user in userManager.Users)
            {
                var userAssignViewModel = new UserAssignViewModel
                {
                    UserId = user.Id,
                    UserName = user.UserName
                };

                model.Add(userAssignViewModel);
            }

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> AssignBug(List<UserAssignViewModel> model, int id)
        {
            var bugReport = reportRepository.GetBugReport(id);


            if (bugReport == null)
            {
                ViewBag.ErrorMessage = $"Report with Id = {id} cannot be found";
                return View("NotFound");
            }

            for (int i = 0; i < model.Count; i++)
            {
                var user = await userManager.FindByIdAsync(model[i].UserId);

                if (model[i].IsSelected)
                {
                    bugReport.AssignedTo = user.FirstName + user.LastName;
                    break;
                }
            }

            return RedirectToAction("update", "report", new { Id = id });
        }
    }
}
