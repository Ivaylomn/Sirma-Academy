using System.Text.Json;

namespace HotelRoomReservationSystem
{
    public class UserManagement
    {
        private static string usersFilePath = "users.json";

        public static List<User> LoadUsers()
        {
            if (File.Exists(usersFilePath))
            {
                string json = File.ReadAllText(usersFilePath);
                var users = JsonSerializer.Deserialize<List<User>>(json);
                return users ?? new List<User>();
            }
            return new List<User>();
        }

        public static void SaveUsers(List<User> users)
        {
            string json = JsonSerializer.Serialize(users, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(usersFilePath, json);
        }

        public static void RegisterUser(string username, string password)
        {
            var users = LoadUsers();
            if (users.Any(u => u.Username == username))
            {
                Console.WriteLine("Username already exists.");
                return;
            }

            var newUser = new User(username, password);
            users.Add(newUser);
            SaveUsers(users);
            Console.WriteLine("User registered successfully!");
        }

        public static User LoginUser(string username, string password)
        {
            var users = LoadUsers();
            var user = users.FirstOrDefault(u => u.Username == username && u.Password == password);
            if (user != null)
            {
                Console.WriteLine("Login successful!");
                return user;
            }
            else
            {
                Console.WriteLine("Invalid credentials.");
                return null;
            }
        }
    }
}
