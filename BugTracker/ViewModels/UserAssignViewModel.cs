using BugTracker.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BugTracker.ViewModels
{
    public class UserAssignViewModel
    {

        public UserAssignViewModel()
        {
            TeamMates = new List<TeamMate>();
        }

        public List<TeamMate> TeamMates { get; set; }

        [Required(ErrorMessage = "Select a user for this bug")]
        public string Selected { get; set; }
    }

    public class TeamMate
    {
        public string UserId { get; set; }
        public string UserName { get; set; }
    }
}
