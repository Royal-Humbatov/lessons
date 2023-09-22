using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiCRUD.Models;

namespace WebApiCRUD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase 
    {
        [HttpGet] 

        public async Task<IActionResult> GetAll()
        {
            var categories = new List<Category>
            {
                new Category { Id = 1} ,
                new Category { Name = "Royal"},
                new Category { About = "Perfect"},
                new Category { DateTime = new DateTime()},
                new Category { Place = "Home"} 
            };
            return Ok(categories);  
        }
    }
}
