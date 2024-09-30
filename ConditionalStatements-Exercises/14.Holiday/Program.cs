namespace _14.Holiday
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            double price = 0;
            string destination = string.Empty;
            string typeOfHoliday = string.Empty;
            if (budget <= 100)
            {
                destination = "Bulgaria";
                if (season == "summer")
                {
                    price = budget * 30 / 100;
                    typeOfHoliday = "Camp";
                }
                else
                {
                    price = budget * 70 / 100;
                    typeOfHoliday = "Hotel";
                }
            }
            else if (budget > 100 && budget <= 1000)
            {
                destination = "Europe";
                if (season == "summer")
                {
                    price = budget * 40 / 100;
                    typeOfHoliday = "Camp";
                }
                else
                {
                    price = budget * 80 / 100;
                    typeOfHoliday = "Hotel";
                }
            }
            else
            {
                destination = "Asia";
                price = budget * 90 / 100;
                typeOfHoliday = "Hotel";
            }

            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{typeOfHoliday} – {price:F2}");
        }
    }
}
