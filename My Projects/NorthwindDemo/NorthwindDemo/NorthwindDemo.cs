using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Packt.Shared;

namespace NorthwindDemo
{
    public class NorthwindDemo: DbContext
    {
        public DbSet<Category>? Categories { get; set; }
        public DbSet<Product>? Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (ProjectConstants.DatabaseProvider == "SQLServer")
            {
                string connection = "Data Source=(localdb)\\MSSQLLocalDB;" + "Initital Catalog=Northwind;" + "Integrated Security=true" + "MultipleActiveResultSets=true;";
                optionsBuilder.UseSqlServer(connection);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
            .Property(category => category.CategoryName)
            .IsRequired().HasMaxLength(15); // NO

            if (ProjectConstants.DatabaseProvider == "SQLServer")
            {
                // added to "fix" the lack of decimal support in SQLite
                modelBuilder.Entity<Product>()
                .Property(product => product.Cost)
                .HasConversion<double>();
            }
        }
    }
}

