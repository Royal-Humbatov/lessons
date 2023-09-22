﻿using ApiDeleteProject.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace ApiDeleteProject
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        {
                
        }

        public DbSet<Person> Persons { get; set; } 
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());  
            //base.OnModelCreating(modelBuilder); 
        }
    }
}
