using WebApi.Models;
using WebApi.Utility;

namespace WebApi.Services
{
    public class UserServices
    {
        public List<User> GetUsers() 
        {
            return Constants.Users; 
        }
    }
}
