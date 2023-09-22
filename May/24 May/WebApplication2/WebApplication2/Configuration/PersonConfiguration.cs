using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApplication2.Models;

namespace WebApplication2.Configuration
{
    public class PersonConfiguration : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x=> x.Id ).UseIdentityColumn(1,1);
            builder.Property(x=>x.Name).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Age).IsRequired();
            builder.Property(x => x.Surname).IsRequired().HasMaxLength(50);  
            builder.Property(x => x.Email).IsRequired().HasMaxLength(50);  
        }
    }
}
