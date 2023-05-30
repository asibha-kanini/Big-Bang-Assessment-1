using System;
using System.Collections.Generic;
using Big_Bang_Assessment_1.Model;


namespace Big_Bang_Assessment_1.Repository
{
    public class HotelRepository : IHotel
    {
        private readonly HotelDbcontext _context;

        public HotelRepository(HotelDbcontext  context)
        {
            _context = context;
        }

        public IEnumerable<Hotel> GetHotel()
        {
            return _context.Hotels.ToList();
        }

        public Hotel GetHotelById(int HotelId)
        {
            return _context.Hotels.Find(HotelId);
        }

        public Hotel PostHotel(Hotel hotel)
        {
            _context.Hotels.Add(hotel);
            _context.SaveChanges();
            return hotel;
        }

        public Hotel PutHotel(int HotelId, Hotel hotel)
        {
            var existingHotel = _context.Hotels.Find(HotelId);
            if (existingHotel != null)
            {
                existingHotel.HotelName = hotel.HotelName;
                existingHotel.HotelDescription = hotel.HotelDescription;
                existingHotel.HotelLocation = hotel.HotelLocation;
                _context.SaveChanges();
            }
            return existingHotel;
        }

        public Hotel DeleteHotel(int HotelId)
        {
            var hotel = _context.Hotels.Find(HotelId);
            if (hotel != null)
            {
                _context.Hotels.Remove(hotel);
                _context.SaveChanges();
            }
            return hotel;
        }
    }
}
   
