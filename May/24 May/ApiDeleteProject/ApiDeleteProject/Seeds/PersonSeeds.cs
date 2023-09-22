using ApiDeleteProject.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApiDeleteProject.Seeds
{
    public class PersonSeeds : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.HasData(

                new Person
                {
                    Id = 1,
                    Name = "Royal",
                    Age = 21,
                    Email = "royalhumbatov52@gmail.com",
                    Phone = 489765979,
                    Surname = "Humbatov"
                },

                new Person
                {
                    Id = 2,
                    Name = "Xeyal",
                    Age = 18,
                    Email = "xeyalhumbatov52@gmail.com",
                    Phone = 489765679,
                    Surname = "Humbatli"
                }
                ) ; 
        }
    }
}
