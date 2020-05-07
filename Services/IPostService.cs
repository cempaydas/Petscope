using System.Collections.Generic;
using prof_sofware.Models;

namespace prof_sofware.Services
{
    public interface IPostService
    {
        
        public List<Post> GetPost(int id);
        public Post AddPost(Post post); 
    }
}