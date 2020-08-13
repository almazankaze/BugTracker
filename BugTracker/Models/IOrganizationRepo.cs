using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BugTracker.Models
{
    public interface IOrganizationRepo
    {
        Organization GetOrganization(int id);

        IEnumerable<Organization> GetAll();

        Organization Add(Organization org);

        Organization Delete(int id);
    }
}
