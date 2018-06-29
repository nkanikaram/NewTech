using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NewTech.Core.Model;

namespace NewTech.Core.Interface
{
    public interface IUserRepository : IRepository<User>
    {
        IEnumerable<User> GetAllUsers();
        IEnumerable<User> GetUserById(Func<User, bool> predicate);
        IEnumerable<User> GetUserById(string id);
        IEnumerable<User> GetUserByFName(Func<User, bool> predicate);
        IEnumerable<User> GetUserByFName(string name);
        IEnumerable<User> GetUserByLName(Func<User, bool> predicate);
        IEnumerable<User> GetUserByLName(string name);
    }
}
