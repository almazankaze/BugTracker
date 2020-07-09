using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BugTracker.Models
{
    public interface IUserRepository
    {
        User GetUser(int Id);
        IEnumerable<User> GetUsers();

        User Add(User user);
        User Update(User Userchanges);
        User Delete(int Id);
    }
}
