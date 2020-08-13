using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BugTracker.Models
{
    public class ReportNote
    {
        [Key]
        public int NoteId { get; set; }

        public int ReportId { get; set; }
        [ForeignKey("ReportId")]
        public BugReport BugReport { get; set; }

        public DateTime PostTime { get; set; }
        public string Description { get; set; }
        public string PostedBy { get; set; }
        [NotMapped]
        public string EncryptedUserId { get; set; }
        public string PostedByUserName { get; set; }
        public string PhotoPath { get; set; }
    }
}
