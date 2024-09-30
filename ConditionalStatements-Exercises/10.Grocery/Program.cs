using System.Runtime;

namespace _10.Grocery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string city = Console.ReadLine();
            decimal quantity = decimal.Parse(Console.ReadLine());

            double price = 0;
            switch (city)
            {
                case "Sofia":
                    if (product == "tea")
                    {
                        price = 0.50;
                    }
                    else if (product == "water")
                    {
                        price = 0.70;
                    }
                    else if (product == "juice")
                    {
                        price = 1.20;
                    }
                    else if (product == "sweets")
                    {
                        price = 1.30;
                    }
                    else if (product == "chips")
                    {
                        price = 1.50;
                    }
                    break;
                case "Plovdiv":
                    if (product == "tea")
                    {
                        price = 0.40;
                    }
                    else if (product == "water")
                    {
                        price = 0.70;
                    }
                    else if (product == "juice")
                    {
                        price = 1.15;
                    }
                    else if (product == "sweets")
                    {
                        price = 1.30;
                    }
                    else if (product == "chips")
                    {
                        price = 1.50;
                    }
                    break;
                case "Varna":
                    if (product == "tea")
                    {
                        price = 0.45;
                    }
                    else if (product == "water")
                    {
                        price = 0.70;
                    }
                    else if (product == "juice")
                    {
                        price = 1.10;
                    }
                    else if (product == "sweets")
                    {
                        price = 1.35;
                    }
                    else if (product == "chips")
                    {
                        price = 1.55;
                    }
                    break;
            }

            decimal totalPrice = (decimal)price * quantity;

            Console.WriteLine($"{totalPrice:F2}");
        }
    }
}
