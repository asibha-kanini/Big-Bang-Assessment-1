using System.ComponentModel.DataAnnotations;

namespace Big_Bang_Assessment_1.Model
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        public string? CustomerName { get; set; } = string.Empty;
        public int? CustomerNumber { get; set; }
        public ICollection<Booking>? Bookings { get; set; }
        public Hotel? Hotel { get; set; }
    }
}
