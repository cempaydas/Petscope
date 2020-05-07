using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using prof_sofware.Models;

namespace prof_sofware.Services
{
    public class UserService : IUserService
    {
        private ApplicationDbContext _context;
        public UserService(ApplicationDbContext context)
        {
            this._context = context;

        }

        public User AddUserAsync(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
            return user;
        }

        public string DoInActive(int id)
        {
            throw new System.NotImplementedException();
        }

        public User GetUser(int id)
        {

            var user = _context.Users.FirstOrDefault(x => x.Id == id);
            return user;
        }

        public List<User> GetUsers()
        {
            var user = _context.Users.ToList();
            return user;
        }

        public User UpdateUser(int id, User user)
        {
            throw new System.NotImplementedException();
        }
    }
}