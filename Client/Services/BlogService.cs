using Blog.Client.Shared;
using Blog.Shared;

namespace Blog.Client.Services
{
    public class BlogService : IBlogService
    {
        List<BlogPost> BlogPosts { get; set; } = new List<BlogPost>()
        {
            new BlogPost
            {
                Url = "new-tutorial",
                Title = "A new Tutorial",
                Description = " This is a new tutorial, showing you how to build a blog with Blazor",
                Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum."
            },
            new BlogPost
            {
                Url = "third-blog",
                Title = "My first Blog post",
                Description = "Hi! this is my new shiny blog. Enjoy!",
                Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum."
            },
            new BlogPost
            {
                Url = "second-blog",
                Title = "My Second Blog post",
                Description = "Hi! this is my new shiny blog. Enjoy!",
                Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum."
            },
            new BlogPost
            {
                Url = "third-blog",
                Title = "My Third Blog post",
                Description = "Hi! this is my new shiny blog. Enjoy!",
                Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum."
            }
        };
        public BlogPost GetBlogPostByUrl(string url)
        {
            return BlogPosts.FirstOrDefault(p => p.Url.ToLower().Equals(url.ToLower()));
        }

        public List<BlogPost> GetBlogPosts()
        {
            return BlogPosts;
        }
    }
}
