using System.ComponentModel;

namespace _05.Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            TotalPrice(product, quantity);
        }

        public static void TotalPrice(string product, int quantity)
        {
            const double coffee = 1.50;
            const double water = 1.00;
            const double coke = 1.40;
            const double snacks = 2.00;

            double price = 0;
            if (product == "coffee")
            {
                price = coffee;
            }
            else if (product == "water")
            {
                price = water;
            }
            else if (product == "coke")
            {
                price = coke;
            }
            else if (product == "snacks")
            {
                price = snacks;
            }

            double totalPrice = price * quantity;
            Console.WriteLine($"{totalPrice:F2}");
        }
    }
}
