using CSharpApi_Project.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CSharpApi_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly AppDbContext _context;
        public CategoriesController(AppDbContext context)
        {
                _context = context;
        }

        [HttpGet]
        
        public IActionResult Get()
        {
            var a = _context.Categories.ToList();
            return Ok(a);
        }
    }
}
