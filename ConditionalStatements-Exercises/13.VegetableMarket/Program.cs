using System.Xml;

namespace _13.VegetableMarket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            double price = 0;
            switch (dayOfWeek)
            {
                case "Monday":
                case "Tuesday":
                case "Wednesday":
                case "Thursday":
                case "Friday":
                    if (product == "tomato")
                    {
                        price = 2.50;
                    }
                    else if (product == "onion")
                    {
                        price = 1.20;
                    }
                    else if (product == "lettuce")
                    {
                        price = 0.85;
                    }
                    else if (product == "cucumber")
                    {
                        price = 1.45;
                    }
                    else if (product == "pepper")
                    {
                        price = 5.50;
                    }
                    break;
                case "Saturday":
                case "Sunday":
                    if (product == "tomato")
                    {
                        price = 2.80;
                    }
                    else if (product == "onion")
                    {
                        price = 1.30;
                    }
                    else if (product == "lettuce")
                    {
                        price = 0.85;
                    }
                    else if (product == "cucumber")
                    {
                        price = 1.75;
                    }
                    else if (product == "pepper")
                    {
                        price = 3.50;
                    }
                    break;
                default:
                    break;
            }

            if (price != 0)
            {
                double totalPrice = quantity * price;
                Console.WriteLine($"{totalPrice:F2}");
            }
            else
            {
                Console.WriteLine("error");
            }
            
        }
    }
}
