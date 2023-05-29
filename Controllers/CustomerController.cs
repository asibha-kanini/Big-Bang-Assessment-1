using Big_Bang_Assessment_1.Model;
using Big_Bang_Assessment_1.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Big_Bang_Assessment_1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomer _customerRepository;

        public CustomerController(ICustomer customerRepository)
        {
            _customerRepository = customerRepository;
        }

        [HttpGet]
        public IEnumerable<Customer> Get()
        {
            return _customerRepository.GetCustomer();
        }

        [HttpGet("{id}")]
        public Customer GetById(int id)
        {
            return _customerRepository.GetCustomerById(id);
        }

        [HttpPost]
        public Customer PostCustomer(Customer customer)
        {
            return _customerRepository.PostCustomer(customer);
        }

        [HttpPut("{id}")]
        public Customer PutCustomer(int id, Customer customer)
        {
            return _customerRepository.PutCustomer(id, customer);
        }

        [HttpDelete("{id}")]
        public Customer DeleteCustomer(int id)
        {
            return _customerRepository.DeleteCustomer(id);
        }
        [HttpGet("Filter")]
        public IEnumerable<Hotel> FilterHotel(string HotelLocation)
        {
            return _customerRepository.FilterHotel(HotelLocation);
        }
        [HttpGet("Occupancy")]
        public int GetRoomOccupancy(int RoomId, int HotelId)
        {
            return _customerRepository.GetRoomOccupancy(RoomId, HotelId);
        }
    }
}
    

