using API_TASK.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API_TASK.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly AppDbContext _appDbContext;

        public PersonController(AppDbContext appDbContext)
        {
                _appDbContext = appDbContext;
        }


        [HttpGet]
        public async Task<IEnumerable<Person>> GetProducts()
        {
            return await _appDbContext.Persons.ToListAsync();    
        }

        [HttpGet("{id}")]

        public async Task<ActionResult<Person>> GetPersonById(int id)
        {
            var person = await _appDbContext.Persons.FindAsync(id);

            if (person == null)
            {
                return BadRequest("Deyer Tapilmadi");
            }

            return person;  
        }

        [HttpPost]

        public async Task<ActionResult<Person>> PersonPost(Person person)
        {
            _appDbContext.Persons.Add(person);
            await _appDbContext.SaveChangesAsync();

            return Ok(person);
        } 
    }
}
