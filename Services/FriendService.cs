using System.Collections.Generic;
using System.Linq;
using prof_sofware.Models;

namespace prof_sofware.Services
{
    public class FriendService : IFrienService
    {
         private ApplicationDbContext _context;
        public FriendService(ApplicationDbContext context)
        {
            this._context=context;
            
        }
        public Friend AddFriend(Friend friend)
        {
            _context.Friends.Add(friend);
            _context.SaveChanges();
            return friend;
        }

        public List<Friend> GetFollower(int id)
        {
            var re=_context.Friends.Where(x=>x.FriendPet==id).ToList();
            return re;
        }

        public List<Friend> GetFollowing(int id)
        {
            var re=_context.Friends.Where(x=>x.PetId==id).ToList();
            return re;
        }
    }
}