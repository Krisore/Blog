using Blog.Client.Shared;
using Blog.Server.Data;
using Blog.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;


namespace Blog.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogController : ControllerBase
    {
        private readonly DataContext _context;
        public BlogController(DataContext context)
        {
            this._context = context;
        }
        [HttpGet]
        public ActionResult<List<BlogPost>> GetAllTheBlogPost() 
        {
            return Ok(_context.BlogPosts);

        }
        [HttpGet("{url}")]
        public ActionResult<BlogPost> GetSingleBlogPost(string url) 
        {
            var post = _context.BlogPosts.FirstOrDefault(p => p.Url.ToLower().Equals(url.ToLower()));
            if(post == null) 
            {
                return NotFound("This post does not exist.");

            }
            return Ok(post);
        }
    }
}
