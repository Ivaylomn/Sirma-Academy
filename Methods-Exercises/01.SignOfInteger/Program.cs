using System.Runtime.InteropServices;

namespace _01.SignOfInteger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            PrintNumberSing(number);
        }

        public static void PrintNumberSing(int number)
        {
            //number < 0
            if (int.IsNegative(number))
            {
                Console.WriteLine($"The number {number} is negative.");
            }
            //int.IsPositive(number);
            else if (number > 0)
            {
                Console.WriteLine($"The number {number} is positive.");
            }
            else
            {
                Console.WriteLine($"The number {number} is zero.");
            }
        }
    }
}
