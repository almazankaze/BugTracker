using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BugTracker.Models
{
    public class BugReport
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Severity { get; set; }
        [Required]
        public Cat? Category { get; set; }
        [Required]
        public string Summary { get; set; }
        [Required]
        public string Description { get; set; }

        public DateTime PostTime { get; set; }
        public string Status { get; set; }
        public string AssignedTo { get; set; }
        public string Priority { get; set; }
    }
}
