using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BugTracker.Models
{
    public interface INoteRepository
    {
        ReportNote GetBugNote(int id);

        IEnumerable<ReportNote> GetAllNotes(int reportId);

        ReportNote Add(ReportNote note);

        ReportNote Delete(int id);
    }
}
