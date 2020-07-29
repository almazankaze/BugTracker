using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BugTracker.Models
{
    public interface IReportRepository
    {
        BugReport GetBugReport(int id);

        IEnumerable<BugReport> GetReports();

        IEnumerable<BugReport> GetReportedBugs(string email);

        IEnumerable<BugReport> GetAssignedBugs(string email);

        IEnumerable<BugReport> GetLonelyBugs();

        IEnumerable<BugReport> GetBugsForReview();

        BugReport Add(BugReport bugReport);

        BugReport Update(BugReport reportChanges);

        BugReport Delete(int Id);
    }
}
