using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApplication2.Models;

namespace WebApplication2.Seeds
{
    public class ProductSeeds : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                new Product
                {
                    Id = 1, 
                    Name = "Book",
                    Description="Perfect Book",
                    ProductDateTime = new DateTime()
                },

                 new Product
                 {
                     Id = 2,
                     Name = "Book",
                     Description = "Perfect Book",
                     ProductDateTime = new DateTime()
                 },

                  new Product
                  {
                      Id = 3,
                      Name = "Book",
                      Description = "Perfect Book",
                      ProductDateTime = new DateTime()
                  }

                );
        }
    }
}
