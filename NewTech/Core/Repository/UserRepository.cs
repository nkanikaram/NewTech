using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NewTech.Core.Interface;
using NewTech.Core.Model;

namespace NewTech.Core.Repository
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(NewTechDbContext context) : base(context)
        {
        }
        public IEnumerable<User> GetAllUsers()
        {
            return _context.Users;
        }
        public IEnumerable<User> GetUserById(Func<User, bool> predicate)
        {
            return _context.Users
                .Where(predicate);
        }
        public IEnumerable<User> GetUserById(string id)
        {
            return _context.Users
                .Where(m => m.UsrId == id);
        }
        public IEnumerable<User> GetUserByFName(Func<User, bool> predicate)
        {
            return _context.Users
                .Where(predicate);
        }
        public IEnumerable<User> GetUserByFName(string name)
        {
            return _context.Users
                .Where(m => m.UsrFirstName == name);
        }
        public IEnumerable<User> GetUserByLName(Func<User, bool> predicate)
        {
            return _context.Users
                .Where(predicate);
        }
        public IEnumerable<User> GetUserByLName(string name)
        {
            return _context.Users
                .Where(m => m.UsrLastName == name);
        }
    }
}
