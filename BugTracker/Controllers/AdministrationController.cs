using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BugTracker.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace BugTracker.Controllers
{
    public class AdministrationController : Controller
    {
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly UserManager<ApplicationUser> userManager;

        public AdministrationController(RoleManager<IdentityRole> roleManager, UserManager<ApplicationUser> userManager)
        {
            this.roleManager = roleManager;
            this.userManager = userManager;
        }

        [HttpGet]
        public IActionResult RolesList()
        {
            var roles = roleManager.Roles;
            return View(roles);
        }
    }
}
