namespace HotelRoomReservationSystem
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public List<string> BookingHistory { get; set; }

        public User(string username, string password)
        {
            Username = username;
            Password = password;
            BookingHistory = new List<string>();
        }

        public void AddBooking(string bookingId)
        {
            BookingHistory.Add(bookingId);
        }

        public override string ToString()
        {
            return $"{Username} - Bookings: {string.Join(", ", BookingHistory)}";
        }
    }
}
