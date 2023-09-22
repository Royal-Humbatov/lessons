using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProjects.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceController : ControllerBase
    {
        private readonly IServiceService _serviceService;

        public ServiceController(IServiceService serviceService)
        {
            _serviceService = serviceService;
        }

        [HttpGet]
        public IActionResult GetServiceList()
        {
            var GetListService = _serviceService.TGetList();
            return Ok(GetListService);  
        }

        [HttpPost]
        public IActionResult PostService(Service service)
        {
            _serviceService.TInsert(service); 
            return Ok();  
        }

        [HttpDelete]   
        public IActionResult DeleteServiceById(int id)
        {
            var deleteById = _serviceService.TGetById(id);
            _serviceService.TDelete(deleteById);

            return Ok(deleteById);
        }

        [HttpPut]
        public IActionResult PutService(Service service)
        {
            _serviceService.TUpdate(service);
            return Ok();    
        }

        [HttpGet("{id}")]         
        public IActionResult GetServiceById(int id)
        {
            var IdGet= _serviceService.TGetById(id);    
            return Ok(IdGet);
        }
    }
}
