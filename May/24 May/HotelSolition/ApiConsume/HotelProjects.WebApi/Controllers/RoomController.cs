using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProjects.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomController : ControllerBase
    {
        private readonly IRoomService _roomService;

        public RoomController(IRoomService roomService)
        {
            _roomService = roomService; 
        }

        [HttpGet]
        public IActionResult GetRoom()
        {
           var GetRoomList = _roomService.TGetList();    
            return Ok(GetRoomList);
        }

        [HttpPost]
        public IActionResult AddRoom(Room room)
        {
            _roomService.TInsert(room); 
            return Ok();    
        }

        [HttpDelete]
        public IActionResult DeleteRoomById(int id)
        {
            var DeleteRoomId = _roomService.TGetById(id);
            _roomService.TDelete(DeleteRoomId); 

            return Ok(DeleteRoomId);    
        }

        [HttpPut]   
        public IActionResult UpdateRoom(Room room)
        {
            _roomService.TUpdate(room);
            return Ok();    
        }

        [HttpGet("{id}")]
        public IActionResult GetByIdRoom(int id)
        {
            var DeleteById = _roomService.TGetById(id); 
            return Ok(DeleteById);        
        }
    }
}
