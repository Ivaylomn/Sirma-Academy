namespace HotelRoomReservationSystem
{
    public class Room
    {
        public int RoomNumber { get; set; }
        public string RoomType { get; set; }
        public double PricePerNight { get; set; }
        public double CancellationFee { get; set; }
        public string Status { get; set; } // Available, Booked, etc.

        public Room(int roomNumber, string roomType, double pricePerNight, double cancellationFee, string status)
        {
            RoomNumber = roomNumber;
            RoomType = roomType;
            PricePerNight = pricePerNight;
            CancellationFee = cancellationFee;
            Status = status;
        }

        public override string ToString()
        {
            return $"{RoomNumber} - {RoomType} - {Status} - {PricePerNight} BGN per night";
        }
    }
}
