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

        public ReportController(IReportRepository reportRepository, UserManager<ApplicationUser> userManager)
        {
            this.reportRepository = reportRepository;
            this.userManager = userManager;
        }

        [HttpGet]
        public ViewResult CreateReport()
        {
            return View();
        }

        [HttpGet]
        public ViewResult ViewIssues()
        {
            var model = reportRepository.GetReports();
            return View(model);
        }

        [HttpGet]
        public ViewResult ViewReports()
        {
            var model = reportRepository.GetReports();
            return View(model);
        }

        // get all the details of a report
        [HttpGet]
        public ViewResult IssueDetails(int? id)
        {
            BugReport bugReport = reportRepository.GetBugReport(id.Value);

            // bug report does not exist, show error page
            if (bugReport == null)
            {
                Response.StatusCode = 404;
                return View("ReportNotFound", id);
            }

            return View(bugReport);
        }

        [HttpGet]
        [Authorize(Roles = "Operations, Admin")]
        public ViewResult Update(int id)
        {
            BugReport bugReport = reportRepository.GetBugReport(id);

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
                Organization = bugReport.Organization
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
                    Organization = user.Organization
                };

                // add new employee to database
                reportRepository.Add(newReport);
                return RedirectToAction("dashboard", "home");
            }

            return View();
        }

        [HttpPost]
        public IActionResult Update(ReportUpdateViewModel model)
        {

            BugReport bugReport = reportRepository.GetBugReport(model.Id);
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
