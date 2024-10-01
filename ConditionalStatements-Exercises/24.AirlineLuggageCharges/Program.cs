using System.Linq.Expressions;

namespace _24.AirlineLuggageCharges
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int weight = int.Parse(Console.ReadLine());
            int dimension = int.Parse(Console.ReadLine());

            int fee = 0;
            string result = string.Empty;
            if (weight > 50)
            {
                fee += 100;
                result += "Overweight + ";
            }

            if (dimension > 158)
            {
                int exceeds = dimension - 158;
                if (exceeds > 0 && exceeds <= 20)
                {
                    fee += 50;
                }
                else if (exceeds > 20 && exceeds <= 50)
                {
                    fee += 100;
                }
                else
                {
                    fee += 200;
                }
                result += "Oversize";
            }

            if (weight > 50 && dimension > 158)
            {
                fee += 50;
                result += " + Handling";
            }

            Console.WriteLine($"${fee} ({result})");
        }
    }
}
