using System.Collections.Generic;
using System.Linq;
using prof_sofware.Models;

namespace prof_sofware.Services
{
    public class UserTypeService : IUserTypeService
    {
        private ApplicationDbContext _context;
        public UserTypeService(ApplicationDbContext context)
        {
            this._context = context;

        }

        public UserType AddUserType(UserType userType)
        {
            _context.UserTypes.Add(userType);
             _context.SaveChanges();
            return userType;
        }

        public UserType GetUserType(int id)
        {
            var user =_context.UserTypes.FirstOrDefault(x=>x.Id==id);
            return user;
            
        }

        public List<UserType> GetUserTypes()
        {
            var users = _context.UserTypes.ToList();
            return users;
        }
    }
}