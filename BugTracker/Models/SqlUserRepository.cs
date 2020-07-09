using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BugTracker.Models
{
    public class SqlUserRepository : IUserRepository
    {
        private readonly AppDbContext context;

        public SqlUserRepository(AppDbContext context)
        {
            this.context = context;
        }

        public User Add(User user)
        {
            context.Users.Add(user);
            context.SaveChanges();
            return user;
        }

        public User Delete(int Id)
        {
            User user = context.Users.Find(Id);

            if (user != null)
            {
                context.Users.Remove(user);
                context.SaveChanges();
            }

            return user;
        }

        public User GetUser(int Id)
        {
            return context.Users.Find(Id);
        }

        public IEnumerable<User> GetUsers()
        {
            return context.Users;
        }

        public User Update(User userChanges)
        {
            var employee = context.Users.Attach(userChanges);
            employee.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return userChanges;
        }
    }
}
