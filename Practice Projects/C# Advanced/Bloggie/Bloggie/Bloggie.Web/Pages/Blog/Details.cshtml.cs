using Bloggie.Web.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Bloggie.Web.Models.Domain;
using Microsoft.AspNetCore.Identity;
using Bloggie.Web.Models.ViewModels;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace Bloggie.Web.Pages.Blog
{
    public class DetailsModel : PageModel
    {
        private readonly IBlogPostRepository blogPostRepository;
        private readonly IBlogPostLikeRepository blogPostLikeRepository;
        private readonly SignInManager<IdentityUser> signInManager;
        private readonly UserManager<IdentityUser> userManager;
        private readonly IBlogPostCommentRepository blogPostCommentRepository;

        public int TotalLikes { get; set; }

        public BlogPost BlogPost { get; set; }
        public bool liked { get; set; }

        public List<BlogComment> Comments { get; set; }

        [BindProperty]
        public Guid BlogPostId { get; set; }

        [BindProperty]
        [Required]
        [MinLength(1)]
        [MaxLength(200)]
        public string CommentDescription { get; set; }



        public DetailsModel(IBlogPostRepository blogPostRepository, IBlogPostLikeRepository blogPostLikeRepository,
            SignInManager<IdentityUser> signInManager, UserManager<IdentityUser> userManager,
            IBlogPostCommentRepository blogPostCommentRepository)
        {
            this.blogPostRepository = blogPostRepository;
            this.blogPostLikeRepository = blogPostLikeRepository;
            this.signInManager = signInManager;
            this.userManager = userManager;
            this.blogPostCommentRepository = blogPostCommentRepository;
        }

        public async Task<IActionResult> OnGet(string urlHandle)
        {
            await GetBlog(urlHandle);

            return Page();
        }

        public async Task<IActionResult> OnPost(string urlHandle)
        {
            if (ModelState.IsValid)
            {
                if (signInManager.IsSignedIn(User) && !string.IsNullOrWhiteSpace(CommentDescription))
                {
                    var userId = userManager.GetUserId(User);
                    var comment = new BlogPostComment()
                    {
                        BlogPostId = BlogPostId,
                        Description = CommentDescription,
                        DateAdded = DateTime.Now,
                        UserId = Guid.Parse(userId)
                    };

                    await blogPostCommentRepository.AddAsync(comment);
                }

                return RedirectToPage("/Blog/Details", new { urlHandle = urlHandle });

            }
            await GetBlog(urlHandle);
            return Page();
        }


        private async Task GetComments()
        {
            var blogPostComments = await blogPostCommentRepository.GetAllAsync(BlogPostId);
            
            var blogPostCommentsViewModel = new List<BlogComment>();

            foreach (var blogPostComment in blogPostComments)
            {
                blogPostCommentsViewModel.Add(new BlogComment()
                {
                    DateAdded = blogPostComment.DateAdded,
                    Description = blogPostComment.Description,
                    UserName = (await userManager.FindByIdAsync(blogPostComment.UserId.ToString())).UserName
                });
            }

            Comments = blogPostCommentsViewModel;
        }

        private async Task GetBlog(string urlHandle)
        {
            BlogPost = await blogPostRepository.GetAsync(urlHandle);

            if (BlogPost != null)
            {
                BlogPostId = BlogPost.Id;

                if (signInManager.IsSignedIn(User))
                {
                    var likes = await blogPostLikeRepository.GetTheLikesForBlog(BlogPost.Id);

                    var userId = userManager.GetUserId(User);

                    liked = likes.Any(x => x.UserId == Guid.Parse(userId));

                    var blogPostComments = await blogPostCommentRepository.GetAllAsync(BlogPost.Id);

                    await GetComments();

                }

                TotalLikes = await blogPostLikeRepository.GetTotalLikeForBlog(BlogPost.Id);

            }
        }
    }

}

