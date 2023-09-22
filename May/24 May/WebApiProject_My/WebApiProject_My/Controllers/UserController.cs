using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiProject_My.Models;
using WebApiProject_My.Services;

namespace WebApiProject_My.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpGet]   
        public List<User> Users ()
        {
            UserServices userServices = new UserServices();
            List<User> users = userServices.GetUsers();
        }
      
    
    }
}
