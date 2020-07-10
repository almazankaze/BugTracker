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
                    PostTime = DateTime.Now

                };

                // add new employee to database
                reportRepository.Add(newReport);
                return RedirectToAction("index", "home");
            }

            return View();
        }
    }
}
