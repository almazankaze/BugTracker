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
    }
}
