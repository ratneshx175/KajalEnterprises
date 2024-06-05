using KajalEnterprises.Models;
using Microsoft.EntityFrameworkCore;

namespace KajalEnterprises.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed data for Categories
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Boards", DisplayOrder = 1 });


            modelBuilder.Entity<Product>().HasData(
            new Product
            {
                Id = 1,
                Title = "White Board",
                Description = "Strong",
                ListPrice = 999,
                RealPrice = 699,
                CategoryId = 1,
                ImageUrl = " "
            });


        }
    }
}
