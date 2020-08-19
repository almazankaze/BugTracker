using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BugTracker.Models;
using BugTracker.Security;
using BugTracker.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;

namespace BugTracker.Controllers
{
    [Authorize]
    public class ReportController : Controller
    {
        private readonly IReportRepository reportRepository;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly INoteRepository noteRepository;
        private readonly IProjectRepo projectRepo;
        private readonly ILogger<AccountController> logger;
        private readonly IDataProtector protector;

        public ReportController(IReportRepository reportRepository, UserManager<ApplicationUser> userManager,
            INoteRepository noteRepository, IProjectRepo projectRepo, ILogger<AccountController> logger,
            IDataProtectionProvider dataProtectionProvider,
            DataProtectionPurposeStrings dataProtectionPurposeStrings)
        {
            this.reportRepository = reportRepository;
            this.userManager = userManager;
            this.noteRepository = noteRepository;
            this.projectRepo = projectRepo;
            this.logger = logger;
            this.protector = dataProtectionProvider.CreateProtector(
                dataProtectionPurposeStrings.UserIdRouteValue);
        }

        [HttpGet]
        public async Task<ViewResult> CreateReport()
        {

            // get logged in user
            var user = await userManager.GetUserAsync(HttpContext.User);

            ViewBag.Projects = new SelectList(projectRepo.GetAllProjects(user.OrganizationId).ToList(), "Id", "Name");

            if (ViewBag.Projects != null)
            {
                return View();
            }

            ViewBag.ErrorTitle = $"Can't create bug report";
            ViewBag.ErrorMessage = $"Cant create a report at this time, please ensure there is atleast 1 project created first.";

            return View("Error");
        }

        [HttpGet]
        public async Task<ViewResult> ViewReports()
        {
            // get current logged in user
            var user = await userManager.GetUserAsync(HttpContext.User);

            var model = reportRepository.GetReports(user.TeamOwner);
            return View(model);
        }

        // get all the details of a report
        [HttpGet]
        public async Task<ViewResult> IssueDetails(int? id)
        {

            BugReport bugReport = reportRepository.GetBugReport(id.Value);

            // bug report does not exist, show error page
            if (bugReport == null)
            {
                Response.StatusCode = 404;
                return View("ReportNotFound", id);
            }

            // get logged in user
            var user = await userManager.GetUserAsync(HttpContext.User);
            ViewBag.teamOwner = user.TeamOwner;

            // get project of this issue
            var project = projectRepo.GetProject(bugReport.ProjectId);

            IssueDetailsViewModel model = new IssueDetailsViewModel
            {
                Id = bugReport.Id,
                Category = bugReport.Category,
                PostTime = bugReport.PostTime,
                LastUpdate = bugReport.LastUpdate,
                Reporter = bugReport.Reporter,
                AssignedTo = bugReport.AssignedTo,
                Priority = bugReport.Priority,
                Severity = bugReport.Severity,
                Status = bugReport.Status,
                Resolution = bugReport.Resolution,
                Summary = bugReport.Summary,
                Description = bugReport.Description,
                TeamOwner = bugReport.TeamOwner,
                ProjectName = project.Name,
                Notes = noteRepository.GetAllNotes(bugReport.Id).Select
                            (e =>
                            {
                                e.EncryptedUserId = protector.Protect(e.PostedBy);
                                return e;
                            })
                    
        };

            return View(model);
        }

        [HttpGet]
        [Authorize(Roles = "Operations, Admin")]
        public async Task<ViewResult> Update(int id)
        {
            // get logged in user
            var user = await userManager.GetUserAsync(HttpContext.User);

            BugReport bugReport = reportRepository.GetBugReport(id);

            // check that user belongs to correct organization and can edit
            if(user.TeamOwner != bugReport.TeamOwner)
            {
                return View("NoAccess");
            }

            if(bugReport.Resolution == "Closed")
            {
                ViewBag.ErrorTitle = $"Bug report is closed";
                ViewBag.ErrorMessage = $"Bug with Id " + $"{bugReport.Id} is closed. " +
                    $"Please contact your admin to reopen";

                return View("Error");
            }

            ReportUpdateViewModel reportUpdateViewModel = new ReportUpdateViewModel
            {
                Id = bugReport.Id,
                Severity = bugReport.Severity,
                Category = bugReport.Category,
                Summary = bugReport.Summary,
                Description = bugReport.Description,
                PostTime = bugReport.PostTime,
                LastUpdate = bugReport.LastUpdate,
                Status = bugReport.Status,
                Reporter = bugReport.Reporter,
                ReporterEmail = bugReport.ReporterEmail,
                AssignedTo = bugReport.AssignedTo,
                AssignedToUserName = bugReport.AssignedToUserName,
                Priority = bugReport.Priority,
                Resolution = bugReport.Resolution,
                Organization = bugReport.Organization,
                TeamOwner = bugReport.TeamOwner
            };

            return View(reportUpdateViewModel);
        }

        // creates new report and saves to database
        [HttpPost]
        public async Task<IActionResult> CreateReport(ReportCreateViewModel model)
        {

            if (ModelState.IsValid)
            {
                // get logged in user
                var user = await userManager.GetUserAsync(HttpContext.User);

                BugReport newReport = new BugReport
                {
                    Severity = model.Severity,
                    Category = model.Category,
                    Summary = model.Summary,
                    Description = model.Description.Replace("\n", "<br />"),
                    PostTime = DateTime.Now,
                    LastUpdate = DateTime.Now,
                    Reporter = user.FirstName + " " + user.LastName,
                    ReporterEmail = user.Email,
                    Priority = "None",
                    Status = "Created",
                    Resolution = "Open",
                    Organization = user.Organization,
                    TeamOwner = user.TeamOwner,
                    ProjectId = model.Project
                };

                // add new employee to database
                reportRepository.Add(newReport);
                return RedirectToAction("dashboard", "home");
            }

            return View();
        }

        [HttpPost]
        [Authorize(Roles = "Operations, Admin")]
        public async Task<IActionResult> Update(ReportUpdateViewModel model)
        {

            BugReport bugReport = reportRepository.GetBugReport(model.Id);

            if (bugReport == null)
            {
                ViewBag.ErrorMessage = $"Report with Id = {model.Id} cannot be found and was not updated";
                return View("NotFound");
            }

            bugReport.LastUpdate = DateTime.Now;
            bugReport.Priority = model.Priority;

            if (model.Resolution == null)
            {
                model.Resolution = "Open";
            }

            bugReport.Resolution = model.Resolution;
            bugReport.Status = model.Status;

            // update report in database
            reportRepository.Update(bugReport);

            // create a note
            if (model.Note != null)
            {
                // get logged in user
                var user = await userManager.GetUserAsync(HttpContext.User);

                ReportNote reportNote = new ReportNote
                {
                    ReportId = bugReport.Id,
                    PostTime = bugReport.LastUpdate,
                    Description = model.Note.Replace("\n", "<br />"),
                    PostedBy = user.Id,
                    PostedByUserName = user.Email,
                    PhotoPath = user.PhotoPath
                };

                noteRepository.Add(reportNote);
            }

            return RedirectToAction("issueDetails", new { id = model.Id });
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public IActionResult DeleteReport(BugReport model)
        {
            var report = reportRepository.Delete(model.Id);

            if(report == null)
            {
                ViewBag.ErrorMessage = $"Report with Id = {model.Id} cannot be found";
                return View("NotFound");
            }

            return RedirectToAction("viewreports");
        }
    }
}
