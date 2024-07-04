﻿using Ecommerce.Models;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options) : base(options)
        {
            
        }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { id = 1, Name = "Action", DisplayOrder = 1 },
                new Category { id = 2, Name = "SciFi", DisplayOrder = 2 },
                new Category { id = 3, Name = "History", DisplayOrder = 3 }

                );
        }
    }
}
