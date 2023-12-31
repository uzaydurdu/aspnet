﻿using aspnetEcommerce.Models;
using Microsoft.EntityFrameworkCore;

namespace aspnetEcommerce.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        public DbSet<Category> Categories { get; set; }
    }
}
