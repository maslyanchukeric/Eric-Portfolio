using Bloggie.Web.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Bloggie.Web.Repositories;
using System.Net;

namespace Bloggie.Web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ImagesController : Controller
    {
        private readonly IImageRepository imageRepository; 

        public ImagesController(IImageRepository imageRepository)
        {
            this.imageRepository = imageRepository;
        }

        //create method to have a post key word
        [HttpPost]
        public async Task<IActionResult>UploadAsync(IFormFile file)
        {
            //creating a imgae repository to save the image in the database
            var imageUrl = await imageRepository.UploadAsync(file);

            if (imageUrl == null)
            {
                return Problem("Something went wrong!", null, (int)HttpStatusCode.InternalServerError);
            }

            return Json(new { link = imageUrl }); 
        }
    }
}
