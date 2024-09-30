using System.Diagnostics;

namespace _15.MakeupShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double powderPrice = 2.60;
            const double lipstickPrice = 3;
            const double spiralPrice = 4.10;
            const double shadowsrPrice = 8.20;
            const double correctorsPrice = 2;

            double priceOfRenovation = double.Parse(Console.ReadLine());
            int countOfPowders = int.Parse(Console.ReadLine());
            int countOfLipsticks = int.Parse(Console.ReadLine());
            int countOfSpirals = int.Parse(Console.ReadLine());
            int countofShadows = int.Parse((Console.ReadLine()));
            int countOfCorrectors = int.Parse(Console.ReadLine());

            double price = countOfPowders * powderPrice + countOfLipsticks * lipstickPrice + countOfSpirals * spiralPrice
                + countofShadows * shadowsrPrice + countOfCorrectors * correctorsPrice;
            int orderAmount = countOfPowders + countOfLipsticks + countOfSpirals + countofShadows + countOfCorrectors;

            double discount = 0;
            if (orderAmount >= 50)
            {
                discount = price * 25 / 100;
            }

            price -= discount;
            price -= price * 10 / 100;

            if (price < priceOfRenovation)
            {
                double neededMoney = priceOfRenovation - price;
                Console.WriteLine($"Not enough money! {neededMoney:F2} lv needed.");
            }
            else
            {
                double remainingMoney = price - priceOfRenovation;
                Console.WriteLine($"Yes! {remainingMoney:F2} lv left.");
            }
        }
    }
}
