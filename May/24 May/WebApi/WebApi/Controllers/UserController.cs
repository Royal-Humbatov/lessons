using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi.Models;
using WebApi.Services;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpGet] 
        public List<User> Users()
        {
            UserServices userServices = new UserServices();
            List<User> users = userServices.GetUsers();
            return users;   
        }

    }
}
