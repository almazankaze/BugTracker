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
    [Authorize]
    public class ReportController : Controller
    {
        private readonly IReportRepository reportRepository;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly INoteRepository noteRepository;

        public ReportController(IReportRepository reportRepository, UserManager<ApplicationUser> userManager,
            INoteRepository noteRepository)
        {
            this.reportRepository = reportRepository;
            this.userManager = userManager;
            this.noteRepository = noteRepository;
        }

        [HttpGet]
        public ViewResult CreateReport()
        {
            return View();
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
            // get logged in user
            var user = await userManager.GetUserAsync(HttpContext.User);
            ViewBag.teamOwner = user.TeamOwner;

            BugReport bugReport = reportRepository.GetBugReport(id.Value);

            // bug report does not exist, show error page
            if (bugReport == null)
            {
                Response.StatusCode = 404;
                return View("ReportNotFound", id);
            }

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
                Notes = noteRepository.GetAllNotes(bugReport.Id)
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
                // get id of current logged in user
                var userId = userManager.GetUserId(HttpContext.User);

                // get info of the user
                var user = await userManager.FindByIdAsync(userId);

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
                    TeamOwner = user.TeamOwner
                };

                // add new employee to database
                reportRepository.Add(newReport);
                return RedirectToAction("dashboard", "home");
            }

            return View();
        }

        [HttpPost]
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
                    PostedByUserName = user.Email.Substring(0, user.Email.IndexOf('@')),
                    PhotoPath = user.PhotoPath
                };

                noteRepository.Add(reportNote);
            }

            return RedirectToAction("issueDetails", new { id = model.Id });
        }

        [HttpPost]
        public IActionResult DeleteReport(BugReport model)
        {
            var report = reportRepository.Delete(model.Id);

            if(report == null)
            {
                ViewBag.ErrorMessage = $"Report with Id = {model.Id} cannot be found";
                return View("NotFound");
            }

            return RedirectToAction("viewissues");
        }
    }
}
