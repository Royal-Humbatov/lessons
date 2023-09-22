using API_TASK.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace API_TASK.Seeds
{
    public class PersonSeeds : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.HasData(
                new Person
                {
                    Id = 1,
                    PersonName = "Royal",
                    PersonAge = 22,
                    PersonNumber = 1,
                    PersonSurname = "Humbetov",
                },

                new Person
                {
                    Id = 2,
                    PersonName = "Xeyal",
                    PersonAge = 19,
                    PersonNumber = 2,
                    PersonSurname = "Humbetli",
                },

                 new Person
                 {
                     Id = 3,
                     PersonName = "Xeyyam",
                     PersonAge = 12,
                     PersonNumber = 3,
                     PersonSurname = "Humbetli",
                 }
            );
        }
    }
}
