namespace HotelRoomReservationSystem
{
    public class Admin
    {
        public static void ViewBookings()
        {
            var users = UserManagement.LoadUsers();
            foreach (var user in users)
            {
                Console.WriteLine($"User: {user.Username}");
                foreach (var bookingId in user.BookingHistory)
                {
                    Console.WriteLine($"  - Booking ID: {bookingId}");
                }
            }
        }

        public static void ViewTotalIncome()
        {
            Console.WriteLine("Total income functionality is not yet implemented.");
        }

        public static void AddRoom()
        {
            Console.WriteLine("Functionality to add a new room is not yet implemented.");
        }
    }
}
