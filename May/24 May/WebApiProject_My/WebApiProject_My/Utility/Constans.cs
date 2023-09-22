using WebApiProject_My.Models;

namespace WebApiProject_My.Utility
{
    public static class Constans
    {
        public static List<User> Users = new List<User>()
        {
            new User()
            {
                Name = "Royal",
                Id= 1,
                Email = "roualccskn@gmail.com"
            },

             new User()
            {
                Name = "Xeyal",
                Id= 2,
                Email = "xeygmmk@gmail.com"
            }
        };
    }
}
