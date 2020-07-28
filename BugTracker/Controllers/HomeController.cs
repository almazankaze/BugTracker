using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BugTracker.Models;
using BugTracker.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BugTracker.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly IReportRepository reportRepository;

        public HomeController(IReportRepository reportRepository)
        {
            this.reportRepository = reportRepository;
        }

        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult DashBoard()
        {
            return View();
        }
    }
}
