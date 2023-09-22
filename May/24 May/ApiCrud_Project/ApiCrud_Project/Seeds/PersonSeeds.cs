using ApiCrud_Project.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApiCrud_Project.Seeds
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
                    Surname = "Humbetov",
                    Email = "Royalhummhdcu@gmail.com",
                    Phone = 595698465
                },

                    new Person
                    {
                        Id = 2,
                        Name = "Xeyal",
                        Surname = "Humbetli",
                        Email = "Xeyalhummhdcu@gmail.com",
                        Phone = 984945689
                    }
                );
        }
    }
}
