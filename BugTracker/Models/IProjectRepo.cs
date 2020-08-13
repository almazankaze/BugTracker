using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BugTracker.Models
{
    public interface IProjectRepo
    {
        Project GetProject(int id);

        IEnumerable<Project> GetAllProjects(int OrgId);

        Project Add(Project project);

        Project Delete(int id);
    }
}
