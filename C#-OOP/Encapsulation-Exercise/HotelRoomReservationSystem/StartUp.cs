namespace HotelRoomReservationSystem
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            // Примерен конзолен интерфейс
            Console.WriteLine("Welcome to the Hotel Room Reservation System");
            Console.WriteLine("1. Register");
            Console.WriteLine("2. Login");
            Console.WriteLine("3. Make a Booking");
            Console.WriteLine("4. View Bookings");
            Console.WriteLine("5. Admin Mode");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Console.WriteLine("Enter username:");
                    string username = Console.ReadLine();
                    Console.WriteLine("Enter password:");
                    string password = Console.ReadLine();
                    UserManagement.RegisterUser(username, password);
                    break;

                case "2":
                    Console.WriteLine("Enter username:");
                    username = Console.ReadLine();
                    Console.WriteLine("Enter password:");
                    password = Console.ReadLine();
                    var user = UserManagement.LoginUser(username, password);
                    if (user != null)
                    {
                        break;
                    }
                    break;

                case "3":
                    Console.WriteLine("Enter desired room type:");
                    string roomType = Console.ReadLine();
                    Console.WriteLine("Enter check-in date (YYYY-MM-DD):");
                    DateTime checkIn = DateTime.Parse(Console.ReadLine());
                    Console.WriteLine("Enter check-out date (YYYY-MM-DD):");
                    DateTime checkOut = DateTime.Parse(Console.ReadLine());

                    break;

                case "4":
                    break;

                case "5":
                    break;
            }
        }
    }
}
