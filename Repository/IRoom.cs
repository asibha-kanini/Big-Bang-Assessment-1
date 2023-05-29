using Big_Bang_Assessment_1.Model;

namespace Big_Bang_Assessment_1.Repository
{
    public interface IRoom
    {
        public IEnumerable<Room> GetRoom();
        public Room GetRoomById(int RoomId);
        public Room PostRoom(Room room);
        public Room PutRoom(int RoomId, Room room);
        public Room DeleteRoom(int RoomId);
    }
}
