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

        BugReport Add(BugReport bugReport);

        BugReport Update(BugReport reportChanges);
    }
}
