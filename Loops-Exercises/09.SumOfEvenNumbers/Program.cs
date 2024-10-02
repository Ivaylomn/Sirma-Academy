using System;

namespace SumOfEvenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                // Първото четно число е 2 * 1, второто е 2 * 2 и т.н.
                int evenNumber = 2 * i;
                sum += evenNumber;
            }

            Console.WriteLine($"Sum: {sum}");
        }
    }
}
