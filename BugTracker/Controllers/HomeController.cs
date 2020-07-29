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
    public class HomeController : Controller
    {
        private readonly IReportRepository reportRepository;
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly UserManager<ApplicationUser> userManager;

        public HomeController(RoleManager<IdentityRole> roleManager, UserManager<ApplicationUser> userManager, IReportRepository reportRepository)
        {
            this.roleManager = roleManager;
            this.userManager = userManager;
            this.reportRepository = reportRepository;
        }

        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }
        
        [HttpGet]
        public async Task<IActionResult> DashBoard()
        {
            // get current logged in user
            var user = await userManager.GetUserAsync(HttpContext.User);

            var model = new DashViewModel();

            // get list of bugs user has reported
            model.ReportedBugs = reportRepository.GetReportedBugs(user.Email);

            // get list of bugs user is assigned to
            model.AssignedBugs = reportRepository.GetAssignedBugs(user.Email);

            // get list of bugs that need to be assigned to someone
            model.NeedUsers = reportRepository.GetLonelyBugs();

            // get list of bugs that need to be reviewed to be closed
            model.NeedReview = reportRepository.GetBugsForReview();

            return View(model);
        }
    }
}
