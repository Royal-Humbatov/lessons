using API_TASK.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace API_TASK
{
    public class AppDbContext : DbContext 
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        {
                
        }


        public DbSet<Category> Categories { get; set; } 
        public DbSet<Person> Persons { get; set; }  
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
           // base.OnModelCreating(modelBuilder);
        }
    }
}
