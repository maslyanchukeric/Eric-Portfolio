using Bloggie.Web.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace Bloggie.Web.Data
{
    public class BloggieDbContext : DbContext //database birdge web app talks to database through this class
    {
        //create constructor for BloggieDbContext
        public BloggieDbContext(DbContextOptions<BloggieDbContext> options) : base(options) //This receives configuration from Program.cs and passes it to the base class constructor
        {

        }

        //properties to represent the the domain models as tables in the database
        public DbSet<BlogPost> BlogPosts { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<BlogPostLike> BlogPostLike { get; set; }
        public DbSet<BlogPostComment> BlogPostComments
        {
            get; set;
        }
    }
}
