using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BugTracker.Models;
using BugTracker.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BugTracker.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUserRepository userRepository;
        private readonly IReportRepository reportRepository;

        public HomeController(IUserRepository userRepository, IReportRepository reportRepository)
        {
            this.userRepository = userRepository;
            this.reportRepository = reportRepository;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ViewResult Create()
        {
            return View();
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
            if(bugReport == null)
            {
                return View("ReportNotFound", id);
            }

            return View(bugReport);
        }

        // creates new user and saves to database
        [HttpPost]
        public IActionResult Create(UserCreateViewModel model)
        {

            if (ModelState.IsValid)
            {

                User newUser = new User
                {
                    UserName = model.UserName,
                    Email = model.Email,
                    Organization = model.Organization,
                    Account = model.Account
                  
                };

                // add new employee to database
                userRepository.Add(newUser);
                return RedirectToAction("index");
            }

            return View();
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
                return RedirectToAction("index");
            }

            return View();
        }
    }
}
