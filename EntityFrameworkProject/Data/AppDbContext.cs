using EntityFrameworkProject.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace EntityFrameworkProject.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
        }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<SliderDetail> SliderDetails { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Blog> Blogs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Blog>().HasQueryFilter(m => !m.IsDeleted);
            modelBuilder.Entity<Blog>().HasData(
                new Blog
                {
                    Id = 1,
                    IsDeleted = false,
                    Title = "Blog1",
                    Desc = "Desc1",
                    Image = "blog-feature-img-1.jpg",
                    Date = DateTime.Now
                },

                 new Blog
                 {
                     Id = 2,
                     IsDeleted = false,
                     Title = "Blog2",
                     Desc = "Desc2",
                     Image = "blog-feature-img-3.jpg",
                     Date = DateTime.Now
                 },

                  new Blog
                  {
                      Id = 3,
                      IsDeleted = false,
                      Title = "Blog3",
                      Desc = "Desc3",
                      Image = "blog-feature-img-4.jpg",
                      Date = DateTime.Now
                  });

        }

    }
}
