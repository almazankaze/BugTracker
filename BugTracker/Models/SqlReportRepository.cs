using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BugTracker.Models
{
    public class SqlReportRepository : IReportRepository
    {

        private readonly AppDbContext context;

        public SqlReportRepository(AppDbContext context)
        {
            this.context = context;
        }

        public BugReport Add(BugReport bugReport)
        {
            context.BugReports.Add(bugReport);
            context.SaveChanges();
            return bugReport;
        }

        public BugReport GetBugReport(int id)
        {
            return context.BugReports.Find(id);
        }

        public IEnumerable<BugReport> GetReports()
        {
            return context.BugReports;
        }
    }
}
