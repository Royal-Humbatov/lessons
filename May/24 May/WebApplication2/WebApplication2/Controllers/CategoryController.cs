using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;
using WebApplication2.Repositories.Core;

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryRepository<Category> _categoryRepository;

        public CategoryController(ICategoryRepository<Category> categoryRepository)
        {
                _categoryRepository = categoryRepository;
        }

        [HttpGet]
        public Task<IActionResult> GetCategory()
        {
          var categoryy = _categoryRepository.GetAll();
            return (categoryy);
        }
    }
}
