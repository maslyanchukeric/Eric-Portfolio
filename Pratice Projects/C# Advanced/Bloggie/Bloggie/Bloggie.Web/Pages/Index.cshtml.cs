using Bloggie.Web.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Bloggie.Web.Repositories;
using System.Runtime.CompilerServices;
using Bloggie.Web.Models.Domain;

namespace Bloggie.Web.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IBlogPostRepository blogPostRepository;
        private readonly ITagRepository tagRepoistory;

        public List<BlogPost> Blogs  { get; set; }
        public List<Tag> Tags { get; set; }

        public IndexModel(ILogger<IndexModel> logger, IBlogPostRepository blogPostRepository, ITagRepository tagRepository)
        {
            _logger = logger;
            this.blogPostRepository = blogPostRepository;
            this.tagRepoistory = tagRepository;

        }
        public async Task<IActionResult> OnGet()
        {
           Blogs = (await blogPostRepository.GetAllAsync()).ToList();
           Tags = (await tagRepoistory.GetAllAsync()).ToList();
            return Page();
        }
    }
}
