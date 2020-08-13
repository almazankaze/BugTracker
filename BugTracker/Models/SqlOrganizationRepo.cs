using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BugTracker.Models
{
    public class SqlOrganizationRepo : IOrganizationRepo
    {
        private readonly AppDbContext context;

        public SqlOrganizationRepo(AppDbContext context)
        {
            this.context = context;
        }

        public Organization Add(Organization org)
        {
            context.Organizations.Add(org);
            context.SaveChanges();
            return org;
        }

        public Organization Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Organization> GetAll()
        {
            return context.Organizations;
        }

        public Organization GetOrganization(int id)
        {
            return context.Organizations.Find(id);
        }
    }
}
