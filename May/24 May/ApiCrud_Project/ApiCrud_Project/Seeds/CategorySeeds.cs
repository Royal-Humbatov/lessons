using ApiCrud_Project.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApiCrud_Project.Seeds
{
    public class CategorySeeds : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(

               new Category
               {
                   Id = 1,
                   Name = "T-Shirt",
                   Price=20,
                   DateTime = new DateTime()
               },

                new Category
                {
                    Id = 2,
                    Name = "Cup",
                    Price = 50,
                    DateTime = new DateTime()
                }

                );

        }
    }
}
