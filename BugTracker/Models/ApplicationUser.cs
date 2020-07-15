using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BugTracker.Models
{
    public class ApplicationUser : IdentityUser
    {

        // add custom columns to database
        public string Organization { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
}
