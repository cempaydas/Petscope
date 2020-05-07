using System.Collections.Generic;
using System.Linq;
using prof_sofware.Models;

namespace prof_sofware.Services
{
    public class PostService : IPostService
    {
        private ApplicationDbContext _context;
        public PostService(ApplicationDbContext context)
        {
            this._context = context;

        }
        public Post AddPost(Post post)
        {
            _context.Posts.Add(post);
            _context.SaveChanges();
            return post;
        }

        public List<Post> GetPost(int id)
        {
            var re = _context.Posts.Where(x => x.Pet.Id==id).ToList();
            return re;
        }
    }
}