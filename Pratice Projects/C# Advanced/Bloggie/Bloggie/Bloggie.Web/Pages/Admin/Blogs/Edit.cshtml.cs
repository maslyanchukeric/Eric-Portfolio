using Bloggie.Web.Enums;
using Bloggie.Web.Models.Domain;
using Bloggie.Web.Models.ViewModels;
using Bloggie.Web.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using System.Text.Json;

namespace Bloggie.Web.Pages.Admin.Blogs
{
    [Authorize(Roles = "Admin")]
    public class EditModel : PageModel
    {
        private readonly IBlogPostRepository blogPostRepository;

        [BindProperty]
        public EditBlogPostRequest BlogPost { get; set; }

        [BindProperty]
        public IFormFile FeaturedImage { get; set; }

        [BindProperty]
        [Required]
        public string Tags { get; set; }

        public EditModel(IBlogPostRepository blogPostRepository)
        {
            this.blogPostRepository = blogPostRepository;
        }

        public async Task OnGet(Guid id)
        {
            var blogPostDomainModel = await blogPostRepository.GetAsync(id);

            if(blogPostDomainModel != null && blogPostDomainModel.Tags != null)
            {
                BlogPost = new EditBlogPostRequest
                {
                    Id = blogPostDomainModel.Id,
                    Heading = blogPostDomainModel.Heading,
                    PageTitle = blogPostDomainModel.PageTitle,
                    Content = blogPostDomainModel.Content,
                    ShortDescription = blogPostDomainModel.ShortDescription,
                    FeaturedImageUrl = blogPostDomainModel.FeaturedImageUrl,
                    UrlHandle = blogPostDomainModel.UrlHandle,
                    PublishedDate = blogPostDomainModel.PublishedDate,
                    Author = blogPostDomainModel.Author,
                    Visible = blogPostDomainModel.Visible
                };

                Tags = string.Join(',', blogPostDomainModel.Tags.Select(x => x.Name));
            }           
        }

        public async Task<IActionResult> OnPostEdit()
        {
            EditBlogBlogPost();

            // Stop and show the page when there are errors
            if (!ModelState.IsValid)
            {
                return Page();
            }

            try
            {
                var blogPostDomainModel = new BlogPost
                {
                    Id = BlogPost.Id,
                    Heading = BlogPost.Heading,
                    PageTitle = BlogPost.PageTitle,
                    Content = BlogPost.Content,
                    ShortDescription = BlogPost.ShortDescription,
                    FeaturedImageUrl = BlogPost.FeaturedImageUrl,
                    UrlHandle = BlogPost.UrlHandle,
                    PublishedDate = BlogPost.PublishedDate,
                    Author = BlogPost.Author,
                    Visible = BlogPost.Visible,
                    Tags = Tags.Split(',')
                        .Select(x => new Tag
                        {
                            Name = x.Trim()
                        })
                        .ToList()
                };

                await blogPostRepository.UpdateAsync(blogPostDomainModel);

                ViewData["Notification"] = new Notification
                {
                    Message = "Record updated successfully!",
                    Type = NotificationType.Success
                };
            }
            catch
            {
                ViewData["Notification"] = new Notification
                {
                    Message = "Something went wrong",
                    Type = NotificationType.Error
                };
            }

            return Page();
        }

        public async Task<IActionResult> OnPostDelete()
        {
            var deleted = await blogPostRepository.DeleteAsync(BlogPost.Id);

            if (deleted)
            {
                var notification = new Notification
                {
                    Type = Enums.NotificationType.Success,
                    Message = "Blog was deleted successfully!"
                };

                TempData["Notification"] = JsonSerializer.Serialize(notification);

                return RedirectToPage("/Admin/Blogs/List");
            }

            return Page();
        }

        private void EditBlogBlogPost()
        {
            if (string.IsNullOrWhiteSpace(BlogPost.Heading))
            {
                ModelState.AddModelError(
                    "BlogPost.Heading",
                    "Heading is required"
                );
            }
            else if (BlogPost.Heading.Length < 10 ||
                     BlogPost.Heading.Length > 100)
            {
                ModelState.AddModelError(
                    "BlogPost.Heading",
                    "Heading can only be 10 - 100 characters"
                );
            }
        }
    }
}