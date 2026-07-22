using Bloggie.Web.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Bloggie.Web.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly AuthDbContext authDbContext;
        private readonly UserManager<IdentityUser> userManager;

        public UserRepository(AuthDbContext authDbContext, UserManager<IdentityUser> userManager)
        {
            this.authDbContext = authDbContext;
            this.userManager = userManager;
        }

        public async Task<bool> Add(IdentityUser identityUser, string password, List<string> roles)
        {
            
            var identityResult = await userManager.CreateAsync(identityUser, password);

            if(identityResult.Succeeded)
            {
                identityResult = await userManager.AddToRolesAsync(identityUser, roles);

                if(identityResult.Succeeded)
                {
                    return true;
                }
            }

            return false;
        }

        public async Task Delete(Guid userId)
        {
            var user = await userManager.FindByIdAsync(userId.ToString());

            if(user != null)
            {
                await userManager.DeleteAsync(user);
            }
        }

        public async Task<IEnumerable<IdentityUser>> GetAll()
        {
            var users = await authDbContext.Users.ToListAsync(); //get the users from the database
            var superAdminUser = await authDbContext.Users.
                FirstOrDefaultAsync(x => x.Email == "superadmin@bloggie.com"); //get the super admin user from the database

            if (superAdminUser != null) //find super admin user
            {
                users.Remove(superAdminUser); //remove the super admin user from the list of users
            }

            return users; //return the list of users without the super admin user
        }

        
    }
}
