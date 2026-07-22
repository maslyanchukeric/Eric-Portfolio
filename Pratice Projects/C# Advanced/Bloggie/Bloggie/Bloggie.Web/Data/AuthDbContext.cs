using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Bloggie.Web.Data
{
    // This is your Identity database context (handles users + roles)
    public class AuthDbContext : IdentityDbContext
    {
        public AuthDbContext(DbContextOptions<AuthDbContext> options) : base(options)
        {
        }

        // This runs when the database is being created
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // IDs for roles (fixed so EF doesn’t change them)
            var superAdminRoleId = "5dd4c8ba-8e5c-4437-b2fa-c5436d4ee1d8";
            var AdminRoleId = "571088a7-aad3-48d4-833b-4eb75d6afffe";
            var UserRoleId = "2a839305-08be-46d2-b490-79bfbf98aeb6";

            // Create roles
            var roles = new List<IdentityRole>
            {
                new IdentityRole()
                {
                    Name = "SuperAdmin",
                    NormalizedName = "SUPERADMIN", // must be uppercase
                    Id = superAdminRoleId,
                    ConcurrencyStamp = superAdminRoleId
                },
                new IdentityRole()
                {
                    Name = "Admin",
                    NormalizedName = "ADMIN",
                    Id = AdminRoleId,
                    ConcurrencyStamp = AdminRoleId
                },
                new IdentityRole()
                {
                    Name = "User",
                    NormalizedName = "USER",
                    Id = UserRoleId,
                    ConcurrencyStamp = UserRoleId
                },
            };

            // Add roles to database
            builder.Entity<IdentityRole>().HasData(roles);

            // Create Super Admin user
            var superAdminId = "929a2627-cb4b-47cc-912f-4389df51eff7";
            var superAdminUserId = new IdentityUser()
            {
                Id = superAdminId,
                UserName = "superadmin@bloggie.com",
                NormalizedUserName = "SUPERADMIN@BLOGGIE.COM",
                Email = "superadmin@bloggie.com",
                NormalizedEmail = "SUPERADMIN@BLOGGIE.COM",

                // This is the hashed password (NOT plain text)
                PasswordHash = "AQAAAAEAAYagAAAAEAARIjNEVWZ3iJmqu8zd7v9G3aY3iqsKoPleGJ/P2c8JeppSmy4zWMEu7Nd69ijz5A==",

                // Required Identity fields
                SecurityStamp = "929a2627-cb4b-47cc-912f-4389df51eff7",
                ConcurrencyStamp = "929a2627-cb4b-47cc-912f-4389df51eff7"
            };

            // Add user to database
            builder.Entity<IdentityUser>().HasData(superAdminUserId);

            // Give Super Admin all roles
            var superAdminRole = new List<IdentityUserRole<string>>()
            {
                new IdentityUserRole<string>
                {
                    RoleId = superAdminRoleId,
                    UserId = superAdminId
                },
                new IdentityUserRole<string>
                {
                    RoleId = AdminRoleId,
                    UserId = superAdminId
                },
                new IdentityUserRole<string>
                {
                    RoleId = UserRoleId,
                    UserId = superAdminId
                },
            };

            // Save role assignments
            builder.Entity<IdentityUserRole<string>>().HasData(superAdminRole);
        }
    }
}