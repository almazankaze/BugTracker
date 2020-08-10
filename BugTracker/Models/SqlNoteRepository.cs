using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BugTracker.Models
{
    public class SqlNoteRepository : INoteRepository
    {

        private readonly AppDbContext context;

        public SqlNoteRepository(AppDbContext context)
        {
            this.context = context;
        }

        public ReportNote Add(ReportNote note)
        {
            context.ReportNotes.Add(note);
            context.SaveChanges();
            return note;
        }

        public ReportNote Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ReportNote> GetAllNotes(int reportId)
        {
            return context.ReportNotes.Where(note => note.ReportId == reportId);
        }

        public ReportNote GetBugNote(int id)
        {
            return context.ReportNotes.Find(id);
        }
    }
}
