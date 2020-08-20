using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BugTracker.ViewModels
{
    public class ReopenViewModel
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Reason for reopening:")]
        public string Note { get; set; }
    }
}
