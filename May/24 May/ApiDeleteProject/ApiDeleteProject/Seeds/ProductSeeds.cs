using ApiDeleteProject.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApiDeleteProject.Seeds
{
    public class ProductSeeds : IEntityTypeConfiguration<Product>
    { 
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                new Product
                {
                    Id = 1,
                    Name = "T-Shirt",
                    DateTime = new DateTime(),
                    Description = "BeatifulProduct",
                },

                  new Product
                  {
                      Id = 2,
                      Name = "BallonDor",
                      DateTime = new DateTime(),
                      Description = "BeatifulBallonDor",
                  }

                );
        }
    }
}
