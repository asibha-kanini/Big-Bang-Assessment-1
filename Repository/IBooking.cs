using Big_Bang_Assessment_1.Model;

namespace Big_Bang_Assessment_1.Repository
{
    public interface IBooking
    {
        public IEnumerable<Booking> GetBooking();
        public Booking GetBookingById(int BookingId);
        public Booking PostBooking(Booking booking);
        public Booking PutBooking(int BookingId, Booking booking);
        public Booking DeleteBooking(int BookingId);
    }
}
