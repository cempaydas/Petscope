using System.Collections.Generic;
using prof_sofware.Models;

namespace prof_sofware.Services
{
    public interface IUserTypeService
    {
        public List<UserType> GetUserTypes();
        public UserType GetUserType(int id);
        public UserType AddUserType(UserType user);
    }
}