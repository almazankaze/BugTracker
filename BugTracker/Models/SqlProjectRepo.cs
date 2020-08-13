using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BugTracker.Models
{
    public class SqlProjectRepo : IProjectRepo
    {
        private readonly AppDbContext context;

        public SqlProjectRepo(AppDbContext context)
        {
            this.context = context;
        }

        public Project Add(Project project)
        {
            context.Projects.Add(project);
            context.SaveChanges();
            return project;
        }

        public Project Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Project> GetAllProjects(int OrgId)
        {
            throw new NotImplementedException();
        }

        public Project GetProject(int id)
        {
            return context.Projects.FirstOrDefault(proj => proj.OrganizationId == id);
        }
    }
}
