using System.Reflection;

namespace Bloggie.Web.Repositories
{
    public interface IImageRepository
    {
        //create a method to save the image in the database
        Task<string> UploadAsync(IFormFile file);
    }
}
