using Microsoft.AspNetCore.Mvc;
using prof_sofware.Models;
using prof_sofware.Services;

namespace prof_sofware.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PostController:ControllerBase
    {
        private readonly IPostService _IPostService;
        public PostController(IPostService IPostService)
        {
            this._IPostService = IPostService;

        }

         [HttpPost]
        public IActionResult AddPost(Post post)
        {
             if(post==null){
                return BadRequest();
            }
            var re = _IPostService.AddPost(post);
            return Ok(re);
        }

         [HttpGet("{id}")]
        public IActionResult GetPost(int id)
        {
            var re=_IPostService.GetPost(id);
             if(re==null){
                return NotFound();
            }
            return Ok(re);

        }
        
    }
}