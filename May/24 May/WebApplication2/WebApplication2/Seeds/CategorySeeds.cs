using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApplication2.Models;

namespace WebApplication2.Seeds
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
                   Description = "Beatiful",
                   Text = "Hello World",
               },

               new Category
               {
                   Id = 2,
                   CategoryName = "Cupa",
                   Description = "FB Image",
                   Text = "Perfect Cupa",
               }, 

               new Category
               {
                   Id = 3,
                   CategoryName = "Pen",
                   Description = "Thin",
                   Text = "Perfect Pen",
               }

                );
        }  
    }
}
