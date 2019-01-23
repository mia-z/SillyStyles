using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SillyStyles.Domain.Entities;

namespace SillyStyles
{
    public class SillyStylesDbContext : DbContext
    {
        public SillyStylesDbContext(DbContextOptions<SillyStylesDbContext> options)
        : base(options)
        {
            //Empty Constructor required
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Product>(entity => {
                entity.HasIndex(e => e.Slug).IsUnique();
            });
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set;}
    }
}