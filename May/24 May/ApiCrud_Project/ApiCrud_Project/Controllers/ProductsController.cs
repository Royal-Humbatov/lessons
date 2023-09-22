using ApiCrud_Project.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApiCrud_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ProductsController(AppDbContext dbContext)
        {
            _context = dbContext;
        }

        //Get : api/ Products

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product>>> GetProducts()
        {
            return await _context.Products.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetByIdProducts(int id)
        {
            var products = await _context.Products.FindAsync(id);

            if (products == null)
            {
                return BadRequest("Not Found Id");
            }
            return Ok(products);
        }


        [HttpPost]
        public async Task<ActionResult<Product>> CreateProduct(Product product)
        {
            var ProductsPost = _context.Products.Add(product);
            await _context.SaveChangesAsync();

            return Ok(ProductsPost);
        }

    }
}
