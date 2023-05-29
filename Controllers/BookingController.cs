using Big_Bang_Assessment_1.Model;
using Big_Bang_Assessment_1.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Big_Bang_Assessment_1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private readonly IBooking _bookingRepository;

        public BookingController(IBooking bookingRepository)
        {
            _bookingRepository = bookingRepository;
        }

        [HttpGet]
        public IEnumerable<Booking> GetBookings()
        {
            return _bookingRepository.GetBooking();
        }

        [HttpGet("{BookingId}")]
        public IActionResult GetBookingById(int BookingId)
        {
            var booking = _bookingRepository.GetBookingById(BookingId);
            if (booking == null)
                return NotFound();

            return Ok(booking);
        }

        [HttpPost]
        public IActionResult PostBooking(Booking booking)
        {
            var newBooking = _bookingRepository.PostBooking(booking);
            return CreatedAtAction(nameof(GetBookingById), new { BookingId = newBooking.BookingId }, newBooking);
        }

        [HttpPut("{BookingId}")]
        public IActionResult PutBooking(int BookingId, Booking booking)
        {
            var updatedBooking = _bookingRepository.PutBooking(BookingId, booking);
            if (updatedBooking == null)
                return NotFound();

            return Ok(updatedBooking);
        }

        [HttpDelete("{BookingId}")]
        public IActionResult DeleteBooking(int BookingId)
        {
            var deletedBooking = _bookingRepository.DeleteBooking(BookingId);
            if (deletedBooking == null)
                return NotFound();

            return Ok(deletedBooking);
        }
    }
}
    

