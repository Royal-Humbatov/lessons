using API_TASK.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace API_TASK.Configuration
{
    public class PersonConfiguration : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        { 
            builder.HasKey(x => x.Id);
            builder.Property(x => x.PersonName).IsRequired().HasMaxLength(50);
            builder.Property(x => x.PersonSurname).IsRequired().HasMaxLength(100);
            builder.Property(x => x.PersonAge).IsRequired();
            builder.Property(x => x.PersonNumber).IsRequired();
        }
    }
}
