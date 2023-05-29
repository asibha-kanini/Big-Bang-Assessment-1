using System.ComponentModel.DataAnnotations;

namespace Big_Bang_Assessment_1.Model
{
    public class Room
    {
        [Key]
        public int RoomId { get; set; }
        public string? RoomName { get; set; }
        public int Occupancy { get; set; }
        public int Price { get; set; }

        public Hotel? Hotel { get; set; }
        public ICollection<Booking>? Bookings { get; set; }
    }
}
