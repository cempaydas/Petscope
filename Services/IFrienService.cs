using System.Collections.Generic;
using prof_sofware.Models;

namespace prof_sofware.Services
{
    public interface IFrienService
    {
        public List<Friend> GetFollower(int id);
        public List<Friend> GetFollowing(int id);  

        public Friend AddFriend(Friend friend);
    }
}