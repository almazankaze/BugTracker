using BugTracker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BugTracker.ViewModels
{
    public class RoleListViewModelcs
    {
        public RoleListViewModelcs()
        {
            AdminUsers = new List<ApplicationUser>();
            OpUsers = new List<ApplicationUser>();
        }

        public int AdminRoleID { get; set; }
        public int OpRoleID { get; set; }
        public IEnumerable<ApplicationUser> AdminUsers { get; set; }
        public IEnumerable<ApplicationUser> OpUsers { get; set; }
    }
}
