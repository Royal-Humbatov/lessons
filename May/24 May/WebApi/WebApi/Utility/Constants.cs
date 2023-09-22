using WebApi.Models;

namespace WebApi.Utility
{
    public static class Constants
    {
        public static List<User> Users = new List<User>()
        {
            new User()
            {
                Id = 1, 
                Name = "Royal",
                Email = "royakkk@gmail.com",
            },


             new User()
            {
                Id = 2,
                Name = "Xeyal",
                Email = "xeyalllcdbijw@gmail.com",
            }
        };
    }
}
