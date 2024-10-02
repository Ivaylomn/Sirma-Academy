namespace _14.ArmstrongNumberCheck
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int originalNumber = number;
            int numberLength = number.ToString().Length;

            int sum = 0;
            //Solution with For Loop
            //for (int i = 0; i < numberLength; i++)
            //{
            //    int lastDigit = number % 10;
            //    number /= 10;
            //    sum += (int)Math.Pow(lastDigit, numberLength);
            //}

            //Solution with While loop
            while (number > 0)
            {
                int lastDigit = number % 10;
                number /= 10;
                sum += (int)Math.Pow(lastDigit, numberLength);
            }

            if (sum == originalNumber)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
        }
    }
}
