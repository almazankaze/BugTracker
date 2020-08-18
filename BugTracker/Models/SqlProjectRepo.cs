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
            Project project = context.Projects.Find(id);

            if (project != null)
            {
                context.Projects.Remove(project);
                context.SaveChanges();
            }

            return project;
        }

        public IEnumerable<Project> GetAllProjects(int orgId)
        {
            return context.Projects.Where(proj => proj.OrganizationId == orgId);
        }

        public Project GetProject(int id)
        {
            return context.Projects.Find(id);
        }
    }
}
