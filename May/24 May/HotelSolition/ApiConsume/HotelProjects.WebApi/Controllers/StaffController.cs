using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProjects.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StaffController : ControllerBase
    {

        private readonly IStaffService _staffService;
        public StaffController(IStaffService staffService)
        {
            _staffService = staffService;     
        }

        [HttpGet]
        public IActionResult GetStaff()
        {
            var values = _staffService.TGetList();  
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddStaff(Staff staff)
        {
            _staffService.TInsert(staff);   
            return Ok();
        }

        [HttpDelete]
        public IActionResult DeleteStaffById(int id)
        {
            var valuees = _staffService.TGetById(id);   
            _staffService.TDelete(valuees);  

            return Ok(valuees);
        }

        [HttpPut]
        public IActionResult UpdateStaff(Staff staff)
        {
            _staffService.TUpdate(staff);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetByIdStaff(int id)
        {
            var GetById= _staffService.TGetById(id);    
            return Ok(GetById);
        }
    }
}
