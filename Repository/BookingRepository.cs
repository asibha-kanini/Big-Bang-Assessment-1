using Big_Bang_Assessment_1.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Big_Bang_Assessment_1.Repository
{
    public class BookingRepository : IBooking
    {
        private readonly HotelDbcontext _context;

        public BookingRepository(HotelDbcontext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public IEnumerable<Booking> GetBooking()
        {
            return _context.Bookings.ToList();
        }

        public Booking GetBookingById(int BookingId)
        {
            return _context.Bookings.Find(BookingId);
        }

        public Booking PostBooking(Booking booking)
        {
            var b = _context.Hotels.Find(booking.Hotel.HotelId);
            booking.Hotel = b;
            var room = _context.Rooms.Find(booking.Room.RoomId);
            booking.Room = room;

            var customer = _context.Customers.Find(booking.Customer.CustomerId);
            booking.Customer = customer;

            _context.Bookings.Add(booking);
            _context.SaveChanges();
            return booking;
        }

        public Booking PutBooking(int BookingId, Booking booking)
        {
            var existingBooking = _context.Bookings.Find(BookingId);
            if (existingBooking != null)
            {
                existingBooking.CheckInDate = booking.CheckInDate;
                existingBooking.CheckOut = booking.CheckOut;
                existingBooking.Room = booking.Room;

                _context.SaveChanges();
            }
            return existingBooking;
        }

        public Booking DeleteBooking(int BookingId)
        {
            var booking = _context.Bookings.Find(BookingId);
            if (booking != null)
            {
                _context.Bookings.Remove(booking);
                _context.SaveChanges();
            }
            return booking;
        }
    }
}
