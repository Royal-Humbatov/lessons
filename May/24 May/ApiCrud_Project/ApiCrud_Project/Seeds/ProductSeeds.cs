using ApiCrud_Project.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApiCrud_Project.Seeds
{
    public class ProductSeeds : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                new Product
                {
                    ProductId = 1,
                    Name = "Cup",
                    Country = "USA",
                    Description = "PerfectCup",    
                    DateTime = new DateTime()
                },

                 new Product
                 {
                     ProductId = 2,
                     Name = "Book",
                     Country = "UK",
                     Description = "Beatiful Book",
                     DateTime = new DateTime()
                 }

                );
        }
    }
}
