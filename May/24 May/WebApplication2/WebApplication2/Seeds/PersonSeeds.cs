using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApplication2.Models;

namespace WebApplication2.Seeds
{
    public class PersonSeeds : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.HasData(

                new Person
                {
                    Id = 1,
                    Name = "Xeyyam",
                    Surname = "Humbetov",
                    Age=13,
                    Email="xeyyamjmikcjdi@gmail.com",                    
                },
                 new Person
                 {
                     Id = 2,
                     Name = "Vasif",
                     Surname = "Elekberli",
                     Age = 20,
                     Email = "Vasiefhbei@gmail.com",
                 },
                  new Person
                  {
                      Id = 3,
                      Name = "Asif",
                      Surname = "Elekberli",
                      Age = 22,
                      Email = "asifhjdbevufh@gmail.com",
                  }

                );
        }
    }
}
