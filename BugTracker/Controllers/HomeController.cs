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

        [HttpGet]
        public ViewResult CreateReport()
        {
            return View();
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
    }
}
