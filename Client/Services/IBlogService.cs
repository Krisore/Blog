using Blog.Shared;

namespace Blog.Client.Services
{
    public interface IBlogService
    {
        Task<List<BlogPost>> GetBlogPosts();
        Task<BlogPost> GetBlogPostByUrl(string url);
    }
}
