﻿using BugTracker.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BugTracker.ViewModels
{
    public class ReportCreateViewModel
    {

        [Required]
        public string Severity { get; set; }
        [Required]
        public Cat? Category { get; set; }
        [Required]
        public string Summary { get; set; }
        [Required]
        public string Description { get; set; }

        public DateTime PostTime { get; set; }
        public DateTime LastUpdate { get; set; }
        public string Status { get; set; }
        public string Reporter { get; set; }
        public string ReporterEmail { get; set; }
        public string AssignedTo { get; set; }
        public string AssignedToUserName { get; set; }
        public string Priority { get; set; }
        public string Resolution { get; set; }
        public string Organization { get; set; }
        public string TeamOwner { get; set; }

        [Required]
        public int Project { get; set; }
    }
}
