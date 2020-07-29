using BugTracker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BugTracker.ViewModels
{
    public class DashViewModel
    {

        public IEnumerable<BugReport> ReportedBugs { get; set; }
        public IEnumerable<BugReport> AssignedBugs { get; set; }
        public IEnumerable<BugReport> NeedUsers { get; set; }
        public IEnumerable<BugReport> NeedReview { get; set; }

    }
}
