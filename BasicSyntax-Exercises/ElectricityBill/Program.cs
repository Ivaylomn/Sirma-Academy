using System.Runtime.ConstrainedExecution;

namespace ElectricityBill
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfUnitsConsumed = int.Parse(Console.ReadLine());
            double ratePerUnit = double.Parse(Console.ReadLine());

            double totalBill = numberOfUnitsConsumed * ratePerUnit + 10;

            Console.WriteLine($"{totalBill:f2}");
        }
    }
}
