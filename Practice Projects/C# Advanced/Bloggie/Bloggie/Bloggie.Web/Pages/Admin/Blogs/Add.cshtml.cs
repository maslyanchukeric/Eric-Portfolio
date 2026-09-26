using Bloggie.Web.Data;
using Bloggie.Web.Models.Domain;
using Bloggie.Web.Models.ViewModels;
using Bloggie.Web.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using System.Text.Json;

namespace Bloggie.Web.Pages.Admin.Blogs
{
    [Authorize(Roles = "Admin")]
    public class AddModel : PageModel
    {
        private readonly IBlogPostRepository blogPostRepository;

        [BindProperty]
        public IFormFile FeaturedImage { get; set; }

        //properties to hold the values from form 
        [BindProperty]
        public AddBlogPost AddBlogPostRequest { get; set; }

        [BindProperty]
        [Required]
        public string Tags { get; set; }

        public AddModel(IBlogPostRepository blogPostRepository)
        {
            this.blogPostRepository = blogPostRepository;
        }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost()
        {
            ValidateAddBlogPost();
            if (ModelState.IsValid)
            {// Create a BlogPost using the form information
                var blogPost = new BlogPost
                {
                    Heading = AddBlogPostRequest.Heading,
                    PageTitle = AddBlogPostRequest.PageTitle,
                    Content = AddBlogPostRequest.Content,
                    ShortDescription = AddBlogPostRequest.ShortDescription,
                    FeaturedImageUrl = AddBlogPostRequest.FeaturedImageUrl,
                    UrlHandle = AddBlogPostRequest.UrlHandle,
                    PublishedDate = AddBlogPostRequest.PublishedDate,
                    Author = AddBlogPostRequest.Author,
                    Visible = AddBlogPostRequest.Visible,
                    Tags = new List<Tag>(Tags.Split(',').Select(x => new Tag()
                    {
                        Name = x.Trim()
                    })
        )
                };

                // Save the blog post
                await blogPostRepository.AddAsync(blogPost);

                var notification = new Notification
                {
                    Type = Enums.NotificationType.Success,
                    Message = "New blog created successfully!"
                };

                TempData["Notification"] =
                    JsonSerializer.Serialize(notification);

                return RedirectToPage("/Admin/Blogs/List");
            }

            return Page();
        }

        //for choosing date and future date validation
        private void ValidateAddBlogPost()
        {
            if(AddBlogPostRequest.PublishedDate < DateTime.Now.Date)
            {
                //telling the user that date needs to be today or future date
                ModelState.AddModelError("AddBlogPostRequest.PublishedDate", 
                    $"{nameof(AddBlogPostRequest.PublishedDate)} can only be today or a future date.");
            }
        }

    }
}
