using ApiDeleteProject.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApiDeleteProject.Configuration
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(x=>x.Id);
            builder.Property(x => x.Name).IsRequired();
            builder.Property(x =>x.Description).IsRequired();   
            builder.Property(x=>x.DateTime).IsRequired();    
        }
    }
}
