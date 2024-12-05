using System.Text.Json;

namespace HotelRoomReservationSystem
{
    public class RoomManagement
    {
        private static string roomsFilePath = "rooms.json";

        public static List<Room> LoadRooms()
        {
            if (File.Exists(roomsFilePath))
            {
                string json = File.ReadAllText(roomsFilePath);
                var rooms = JsonSerializer.Deserialize<List<Room>>(json);
                return rooms ?? new List<Room>();
            }
            return new List<Room>();
        }

        public static void SaveRooms(List<Room> rooms)
        {
            string json = JsonSerializer.Serialize(rooms, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(roomsFilePath, json);
        }

        public static void AddRoom(Room room)
        {
            var rooms = LoadRooms();
            rooms.Add(room);
            SaveRooms(rooms);
        }

        public static void UpdateRoomStatus(int roomNumber, string status)
        {
            var rooms = LoadRooms();
            var room = rooms.FirstOrDefault(r => r.RoomNumber == roomNumber);
            if (room != null)
            {
                room.Status = status;
                SaveRooms(rooms);
            }
        }

        public static Room GetAvailableRoom(string roomType)
        {
            var rooms = LoadRooms();
            return rooms.FirstOrDefault(r => r.RoomType == roomType && r.Status == "Available");
        }
    }
}
