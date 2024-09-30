using System.Security.Authentication.ExtendedProtection;

namespace _12.SimpleCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numberOne = double.Parse(Console.ReadLine());
            double numberTwo = double.Parse(Console.ReadLine());
            string opperation = Console.ReadLine();

            double result = 0;
            if (opperation == "add")
            {
                result = numberOne + numberTwo;
            }
            else if (opperation == "subtract")
            {
                result = numberOne - numberTwo;
            }
            else if (opperation == "divide")
            {
                result = numberOne / numberTwo;
            }
            else if (opperation == "multiply")
            {
                result = numberOne * numberTwo;
            }

            Console.WriteLine(Math.Round(result, 2));
        }
    }
}
