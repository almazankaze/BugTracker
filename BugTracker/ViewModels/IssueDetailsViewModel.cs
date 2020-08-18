using BugTracker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BugTracker.ViewModels
{
    public class IssueDetailsViewModel
    {
        public IEnumerable<ReportNote> Notes { get; set; }

        public int Id { get; set; }
        public Cat? Category { get; set; }
        public DateTime PostTime { get; set; }
        public DateTime LastUpdate { get; set; }
        public string Reporter { get; set; }
        public string AssignedTo { get; set; }
        public string Priority { get; set; }
        public string Severity { get; set; }
        public string Status { get; set; }
        public string Resolution { get; set; }
        public string Summary { get; set; }
        public string Description { get; set; }
        public string TeamOwner { get; set; }
        public string ProjectName { get; set; }
    }
}
