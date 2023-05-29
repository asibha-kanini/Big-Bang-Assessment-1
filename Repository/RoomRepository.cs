using Big_Bang_Assessment_1.Model;
using Microsoft.EntityFrameworkCore;

namespace Big_Bang_Assessment_1.Repository
{
    public class RoomRepository :IRoom
    {
        private readonly HotelDbcontext _context;

        public RoomRepository(HotelDbcontext context)
        {
            _context = context;
        }

        public IEnumerable<Room> GetRoom()
        {
            return _context.Rooms.ToList();
        }

        public Room GetRoomById(int RoomId)
        {
            return _context.Rooms.Find(RoomId);
        }

        public Room PostRoom(Room room)
        {
            var hotel = _context.Hotels.Find(room.Hotel.HotelId);
            room.Hotel = hotel;
            _context.Rooms.Add(room);
            _context.SaveChanges();
            return room;
        }


        public Room PutRoom(int RoomId, Room room)
        {
            var r = _context.Hotels.Find(room.Hotel.HotelId);
            room.Hotel = r;
           // _context.Entry(room).State = EntityState.Modified;
            _context.SaveChanges();
            return room;
        }

        public Room DeleteRoom(int RoomId)
        {
            var room = _context.Rooms.Find(RoomId);
            if (room != null)
            {
                _context.Rooms.Remove(room);
                _context.SaveChanges();
            }
            return room;
        }
    }
}
    