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

        public BugReport Update(BugReport reportChanges)
        {
            var report = context.BugReports.Attach(reportChanges);
            report.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return reportChanges;
        }

        public BugReport Delete(int Id)
        {
            BugReport report = context.BugReports.Find(Id);

            if (report != null)
            {
                context.BugReports.Remove(report);
                context.SaveChanges();
            }

            return report;
        }
    }
}
