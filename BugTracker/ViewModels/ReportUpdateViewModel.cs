using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BugTracker.ViewModels
{
    public class ReportUpdateViewModel : ReportCreateViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "A note is required for updating")]
        [Display(Name = "Comment")]
        public string Note { get; set; }
    }
}
