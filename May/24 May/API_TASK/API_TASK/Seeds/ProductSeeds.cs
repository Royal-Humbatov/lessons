using API_TASK.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace API_TASK.Seeds
{
    public class ProductSeeds : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                new Product
                {
                    Id = 1,
                    ProductName = "Testr",   
                    ProductDescription = "Description",
                    Number = 1,                   
                },

                 new Product
                 {
                     Id = 2,
                     ProductName = "assdf",
                     ProductDescription = "Descript",
                     Number = 2,
                 }

                );
        }
    }
}
