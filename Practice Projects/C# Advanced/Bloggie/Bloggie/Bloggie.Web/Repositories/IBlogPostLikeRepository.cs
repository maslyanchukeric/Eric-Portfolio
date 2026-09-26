using Bloggie.Web.Models.Domain;

namespace Bloggie.Web.Repositories
{
    public interface IBlogPostLikeRepository
    {
        Task<int> GetTotalLikeForBlog(Guid blogpostID);

        Task AddLikeForBlog(Guid blogpostID, Guid userID);

        Task<IEnumerable<BlogPostLike>> GetTheLikesForBlog(Guid BlogPostId);
    }
}
