using Microsoft.AspNetCore.Mvc;
using prof_sofware.Models;
using prof_sofware.Services;

namespace prof_sofware.Controllers
{
     [ApiController]
    [Route("api/[controller]")]
    public class FriendController:ControllerBase
    {
          private readonly IFrienService _IFrienService;
        public FriendController(IFrienService IFrienService)
        {
            this._IFrienService = IFrienService;

        }
         [HttpPost]
        public IActionResult AddFollowing(Friend friend)
        {
            if(friend==null)
            {
                return BadRequest();
            }
            var re = _IFrienService.AddFriend(friend);
            return Ok(re);
        }
        
        [HttpGet("follower/{id}")]
        public IActionResult FollowerList(int id)
        {
            var re=_IFrienService.GetFollower(id);
            if(re==null){
                return NotFound();
            }
            return Ok(re);

        }

        [HttpGet("following/{id}")]
        public IActionResult FollowingList(int id)
        {
            var re=_IFrienService.GetFollowing(id);
            if(re==null){
                return NotFound();
            }
            return Ok(re);

        }
    }
}