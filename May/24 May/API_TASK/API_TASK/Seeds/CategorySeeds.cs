using API_TASK.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace API_TASK.Seeds
{
    public class CategorySeeds : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(
                new Category
                {
                    Id = 1,
                    CategoryName = "T-Shirt",
                    Country = "Azerbaijan",
                    Description = "Beatiful",
                    Number = 1,                   
                },

                new Category
                {
                    Id = 2,
                    CategoryName = "Cup",
                    Country = "Turkiye",
                    Description = "Perfect",
                    Number = 2,
                },

                new Category
                {
                    Id = 3,
                    CategoryName = "Uniform",
                    Country = "Pakistan",
                    Description = "Nice",
                    Number = 3,
                }

                );
        }
    }
}
