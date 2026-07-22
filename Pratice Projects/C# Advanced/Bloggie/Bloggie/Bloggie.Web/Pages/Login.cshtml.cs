using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Bloggie.Web.Models.ViewModels;
using Microsoft.AspNetCore.Identity;

namespace Bloggie.Web.Pages
{
    public class LoginModel : PageModel
    {
        [BindProperty]
        public Login LoginViewModel { get; set; }

        private readonly SignInManager<IdentityUser> signInManager;

        public LoginModel(SignInManager<IdentityUser> signInManager)
        {
            this.signInManager = signInManager;
        }

        public void OnGet()
        {

        }

        public async Task<IActionResult> OnPost(string? ReturnUrl)
        {
            if(ModelState.IsValid)
            {
                var signInResult = await signInManager.PasswordSignInAsync(
                LoginViewModel.Username, LoginViewModel.Password, false, false);

                if (signInResult.Succeeded)
                {
                    if (!string.IsNullOrWhiteSpace(ReturnUrl))
                    {
                        return RedirectToPage(ReturnUrl);
                    }

                    return RedirectToPage("Index");
                }
                else
                {
                    ViewData["notification"] = new Notification
                    {
                        Type = Enums.NotificationType.Error,
                        Message = "Invalid username or password."
                    };
                    return Page();
                }
            }
            
            return Page();
            

            
        }
    }
}