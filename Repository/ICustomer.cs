using Big_Bang_Assessment_1.Model;

namespace Big_Bang_Assessment_1.Repository
{
    public interface ICustomer
    {
        public IEnumerable<Customer> GetCustomer();
        public Customer GetCustomerById(int CustomerId);
        public Customer PostCustomer(Customer customer);
        public Customer PutCustomer(int CustomerId, Customer customer);
        public Customer DeleteCustomer(int CustomerId);
        public IEnumerable<Hotel> FilterHotel(string HotelLocation);
        public int GetRoomOccupancy(int RoomId, int HotelId);
    }
}
