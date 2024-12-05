namespace HotelRoomReservationSystem
{
    public class Booking
    {
        public string BookingId { get; set; }
        public User User { get; set; }
        public Room Room { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }

        public Booking(string bookingId, User user, Room room, DateTime checkInDate, DateTime checkOutDate)
        {
            BookingId = bookingId;
            User = user;
            Room = room;
            CheckInDate = checkInDate;
            CheckOutDate = checkOutDate;
        }

        public override string ToString()
        {
            return $"Booking ID: {BookingId}, Room: {Room.RoomNumber} ({Room.RoomType}), Dates: {CheckInDate.ToShortDateString()} - {CheckOutDate.ToShortDateString()}";
        }
    }
}
