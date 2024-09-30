using System.Diagnostics;
using System.Text;

namespace _22.DiscountCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            string membership = Console.ReadLine();

            string discount = string.Empty;
            if (age < 18)
            {
                discount = "10% discount";
            }
            else if (age >= 18 && age < 65)
            {
                if (membership == "Yes")
                {
                    discount = "20% discount";
                }
                else
                {
                    discount = "10% discount";
                }
            }
            else
            {
                discount = "30% discount";
            }

            Console.WriteLine(discount);
        }
    }
}
