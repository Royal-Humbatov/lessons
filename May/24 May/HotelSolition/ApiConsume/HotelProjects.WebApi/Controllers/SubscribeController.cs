using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProjects.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubscribeController : ControllerBase
    {
        private readonly ISubscribeService _subscribeService;

        public SubscribeController(ISubscribeService subscribeService)
        {
            _subscribeService = subscribeService;
        }

        [HttpGet]
        public IActionResult GetSubscribeList()
        {
          var GetSubscribe = _subscribeService.TGetList();
            return Ok(GetSubscribe);
        }

        [HttpPost]  
        public IActionResult SubscribePost(Subscribe subscribe)
        {
            _subscribeService.TInsert(subscribe);
            return Ok();   
        }

        [HttpDelete] 
        public IActionResult DeleteSubscribeById(int id)
        {
            var DeleteById = _subscribeService.TGetById(id);
            _subscribeService.TDelete(DeleteById);

            return Ok(DeleteById);
        }

        [HttpGet("{id}")]
        public IActionResult GetSubscribeById(int id)
        {
            var IdGet= _subscribeService.TGetById(id);  
            return Ok(IdGet);
        }

        [HttpPut]  
        public IActionResult SubscribeUpdate(Subscribe subscribe)
        {
            _subscribeService.TUpdate(subscribe);   
            return Ok();
        }

    }
}
