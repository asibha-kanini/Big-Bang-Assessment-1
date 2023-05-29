using Big_Bang_Assessment_1.Model;
using Big_Bang_Assessment_1.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Big_Bang_Assessment_1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelController : ControllerBase
    {
        private readonly IHotel _hotelRepository;

        public HotelController(IHotel hotelRepository)
        {
            _hotelRepository = hotelRepository;
        }

        [HttpGet]
        public IEnumerable<Hotel> GetHotel()
        {
            return _hotelRepository.GetHotel();
        }

        [HttpGet("{id}")]
        public Hotel GetById(int id)
        {
            return _hotelRepository.GetHotelById(id);
        }

        [HttpPost]
        public Hotel PostHotel(Hotel hotel)
        {
            return _hotelRepository.PostHotel(hotel);
        }

        [HttpPut("{id}")]
        public Hotel PutHotel(int id, Hotel hotel)
        {
            return _hotelRepository.PutHotel(id, hotel);
        }

        [HttpDelete("{id}")]
        public Hotel DeleteHotel(int id)
        {
            return _hotelRepository.DeleteHotel(id);
        }
    }
}
   
