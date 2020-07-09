using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BugTracker.Models;
using Microsoft.AspNetCore.Mvc;

namespace BugTracker.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUserRepository userRepository;

        public HomeController(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
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
    }
}
