using ApiDeleteProject.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApiDeleteProject.Seeds
{
    public class CategorySeeds : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(

                new Category
                {
                    Id = 1,
                    Name = "Car",
                    CategoryId = 1,
                    Description = "BeatifulCategory",                   
                },

                 new Category
                 {
                     Id = 2,
                     Name = "Cup",
                     CategoryId = 2,
                     Description = "BeatifulCategory2",
                 }
                );
        }
    }
}
