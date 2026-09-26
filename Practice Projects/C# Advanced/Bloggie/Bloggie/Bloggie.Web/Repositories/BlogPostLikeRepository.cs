using Bloggie.Web.Data;
using Bloggie.Web.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace Bloggie.Web.Repositories
{
    public class BlogPostLikeRepository : IBlogPostLikeRepository
    {
        private readonly BloggieDbContext bloggieDbContext;

        public BlogPostLikeRepository(BloggieDbContext bloggieDbContext)
        {
            this.bloggieDbContext = bloggieDbContext;
        }

        public async Task AddLikeForBlog(Guid blogpostID, Guid userID)
        {
            var like = new BlogPostLike
            {
                Id = Guid.NewGuid(),
                BlogPostId = blogpostID,
                UserId = userID
            };
            
            await bloggieDbContext.BlogPostLike.AddAsync(like);
            await bloggieDbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<BlogPostLike>> GetTheLikesForBlog(Guid blogPostId)
        {
            return await bloggieDbContext.BlogPostLike.Where(x => x.BlogPostId == blogPostId)
                .ToListAsync();
        }

        public async Task<int> GetTotalLikeForBlog(Guid blogpostID)
        {
            return await bloggieDbContext.BlogPostLike
                .CountAsync(x => x.BlogPostId == blogpostID);
        }


    }
}
