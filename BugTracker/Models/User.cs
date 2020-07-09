using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BugTracker.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "UserName cannot exceed 50 characters")]
        public string UserName { get; set; }

        [Required]
        [RegularExpression(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$", ErrorMessage = "Invalid Email Format")]
        [Display(Name = "Office Email")]
        public string Email { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "Organization name cannot exceed 50 characters")]
        public string Organization { get; set; }

        [Required]
        public Acct? Account { get; set; }
    }
}
