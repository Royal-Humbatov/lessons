using API_TASK.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace API_TASK.Configuration
{
    public class CategoryConfiguratuion : IEntityTypeConfiguration<Category>  
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Number).IsRequired();
            builder.Property(x => x.Country).HasMaxLength(255);
            builder.Property(x => x.Description).HasMaxLength(255);
            builder.Property(x => x.CategoryName).IsRequired().HasMaxLength(500); 
        }
    }
}
