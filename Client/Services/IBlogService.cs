using Blog.Shared;

namespace Blog.Client.Services
{
    public interface IBlogService
    {
        List<BlogPost> GetBlogPosts();
        BlogPost GetBlogPostByUrl(string url);
    }
}
