namespace _12.PasswordValidator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            if (IsValidLength(password)
                && IsContainOnlyLettersAndDigit(password)
                && IsHaveLeastTwoDigit(password))
            {
                Console.WriteLine("Password is valid!");
                return;
            }

            if (!IsValidLength(password))
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }

            if (!IsContainOnlyLettersAndDigit(password))
            {
                Console.WriteLine("Password must contain only letters and digits");
            }

            if (!IsHaveLeastTwoDigit(password))
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
        }

        public static bool IsValidLength(string password)
        {
            if (!(password.Length >= 6 && password.Length <= 10))
            {
                return false;
            }

            return true;
        }

        public static bool IsContainOnlyLettersAndDigit(string password)
        {
            for (int i = 0; i < password.Length; i++)
            {
                if (!(char.IsLetter(password[i]) || char.IsDigit(password[i])))
                {
                    return false;
                }
            }

            return true;
        }

        public static bool IsHaveLeastTwoDigit(string password)
        {
            int count = 0;
            for (int i = 0; i < password.Length; i++)
            {
                if (char.IsDigit(password[i]))
                {
                    count++;
                }
            }

            if (count < 2)
            {
                return false;
            }

            return true;
        }
    }
}
