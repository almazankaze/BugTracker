using BugTracker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BugTracker.ViewModels
{
    public class RoleListViewModel
    {
        public RoleListViewModel()
        {
            AdminUsers = new List<ApplicationUser>();
            OpUsers = new List<ApplicationUser>();
        }

        public string AdminRoleID { get; set; }
        public string OpRoleID { get; set; }
        public List<ApplicationUser> AdminUsers { get; set; }
        public List<ApplicationUser> OpUsers { get; set; }
    }
}
