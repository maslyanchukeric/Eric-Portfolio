using Bloggie.Web.Models.Domain;

namespace Bloggie.Web.Repositories
{
    public interface IBlogPostRepository
    {
        Task<IEnumerable<BlogPost>> GetAllAsync(); //get all the blog posts
        Task<IEnumerable<BlogPost>> GetAllAsync(string tagName); //get all the blog posts by tag
        Task<BlogPost> GetAsync(Guid id); //get a blog Post
        Task<BlogPost> GetAsync(string urlHandle); //get a blog post by url handle
        Task<BlogPost> AddAsync(BlogPost blogPost); //adds a blog post
        Task<BlogPost> UpdateAsync(BlogPost blogPost); //update blog post
        Task<bool> DeleteAsync(Guid id); //delete a blog

    }
}
