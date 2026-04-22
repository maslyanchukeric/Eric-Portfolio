using Microsoft.EntityFrameworkCore;
using AutoPlusMVC.Models;

namespace AutoPlusMVC.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Car> Cars { get; set; }
        public DbSet<Users> Users { get; set; }
    }
}