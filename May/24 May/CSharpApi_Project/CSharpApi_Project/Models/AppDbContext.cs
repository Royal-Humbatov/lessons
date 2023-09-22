using Microsoft.EntityFrameworkCore;

namespace CSharpApi_Project.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(

                new Category { Id=1, Name="Dress"},
                new Category { Id=2, Name="Shoes"}               
            );

            modelBuilder.Entity<Product>().HasData(
                
                new Product { Id = 1, Name="T-Shirt Man", Price=5, CategoryId=1 },               
                new Product { Id=2, Name="T-Shirt Women" , Price=10, CategoryId=1},
                new Product { Id = 3, Name = "T-Shirt Man", Price= 15, CategoryId=2 },
                new Product { Id = 4, Name = "T-Shirt Women", Price=20, CategoryId=2 }
                );
        }
    }
}
