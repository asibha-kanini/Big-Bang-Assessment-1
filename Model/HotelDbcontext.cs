using Microsoft.EntityFrameworkCore;

namespace Big_Bang_Assessment_1.Model
{
    public class HotelDbcontext : DbContext
    {




        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Customer> Customers { get; set; }

        public DbSet<Booking> Bookings { get; set; }

        public HotelDbcontext(DbContextOptions<HotelDbcontext> options) : base(options)
        {

        }

       
    }
}

