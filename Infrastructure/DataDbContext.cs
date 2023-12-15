using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace Portfolio.Infrastructure
{
    public class DataDbContext : DbContext
    {
        public PortfolioContext(DbContextOptions<PortfolioContext> options)
        : base(options)
        {
        }

        public DbSet<Post> Posts { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Review> Reviews { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Post>().ToTable("Posts");
            modelBuilder.Entity<Project>().ToTable("Projects");
            modelBuilder.Entity<Review>().ToTable("Reviews");
        }
    }
}
