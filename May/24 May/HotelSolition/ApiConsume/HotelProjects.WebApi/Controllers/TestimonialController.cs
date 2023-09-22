using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProjects.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestimonialController : ControllerBase
    {
        private readonly ITestimonialService _testimonialService;
        public TestimonialController(ITestimonialService testimonialService)
        {
            _testimonialService = testimonialService;    
        }

        [HttpGet]
        public IActionResult GetTestimonialList()
        {
            var GetTestimonial = _testimonialService.TGetList();    
            return Ok(GetTestimonial);
        }

        [HttpPost]
        public IActionResult TestimonilaPost(Testimonial testimonial)
        {
            _testimonialService.TInsert(testimonial);
            return Ok();    
        }

        [HttpPut]
        public IActionResult GetTestimonialPut(Testimonial testimonial)
        {
            _testimonialService.TUpdate(testimonial);
            return Ok(testimonial);    
        }

        [HttpDelete]
        public IActionResult GetDeleteById(int id)
        {
            var deleteById= _testimonialService.TGetById(id);   
            _testimonialService.TDelete(deleteById);
            
            return Ok(deleteById);    
        }

        [HttpGet("{id}")]
        public IActionResult GetByIdTestimonial(int id)
        {
            var ByIdTestimonail = _testimonialService.TGetById(id);    
            return Ok(ByIdTestimonail);
        }

    }
}
