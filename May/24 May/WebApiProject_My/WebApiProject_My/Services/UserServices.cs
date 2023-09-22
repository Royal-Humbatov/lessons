using WebApiProject_My.Models;
using WebApiProject_My.Utility;

namespace WebApiProject_My.Services
{
    public class UserServices
    {
        public List<User> GetUsers()
        {
            return Constans.Users;
        }
    }
}
