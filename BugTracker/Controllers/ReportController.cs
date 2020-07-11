using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BugTracker.Models;
using BugTracker.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BugTracker.Controllers
{
    public class ReportController : Controller
    {
        private readonly IReportRepository reportRepository;

        public ReportController(IReportRepository reportRepository)
        {
            this.reportRepository = reportRepository;
        }

        [HttpGet]
        public ViewResult CreateReport()
        {
            return View();
        }

        [HttpGet]
        public ViewResult ViewReports()
        {
            var model = reportRepository.GetReports();
            return View(model);
        }

        [HttpGet]
        public ViewResult ReportDetails(int? id)
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

        // get all the details of a report
        [HttpGet]
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
                AssignedTo = bugReport.AssignedTo,
                Priority = bugReport.Priority,
                Resolution = bugReport.Resolution
            };

            return View(reportUpdateViewModel);
        }

        // creates new report and saves to database
        [HttpPost]
        public IActionResult CreateReport(ReportCreateViewModel model)
        {

            if (ModelState.IsValid)
            {

                BugReport newReport = new BugReport
                {
                    Severity = model.Severity,
                    Category = model.Category,
                    Summary = model.Summary,
                    Description = model.Description.Replace("\n", "<br />"),
                    PostTime = DateTime.Now,
                    LastUpdate = DateTime.Now,
                    Priority = "None",
                    Status = "Created",
                    Resolution = "None"

                };

                // add new employee to database
                reportRepository.Add(newReport);
                return RedirectToAction("index", "home");
            }

            return View();
        }

        [HttpPost]
        public IActionResult Update(ReportUpdateViewModel model)
        {


                BugReport bugReport = reportRepository.GetBugReport(model.Id);
                bugReport.LastUpdate = DateTime.Now;
                bugReport.Priority = model.Priority;
                bugReport.Resolution = model.Resolution;
                bugReport.Status = model.Status;

                // update report in database
                reportRepository.Update(bugReport);
                return RedirectToAction("reportDetails", new { id = model.Id });
        }
    }
}
