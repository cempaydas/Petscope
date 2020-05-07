using System.Collections.Generic;
using prof_sofware.Models;

namespace prof_sofware.Services
{
    public interface IUserService
    {
         public  List<User> GetUsers();
         public User AddUserAsync(User user);

         public User UpdateUser(int id,User user);
         public string DoInActive(int id);

          public User GetUser(int id);

    }
}