namespace _19.PadawanEquipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int studentCount = int.Parse(Console.ReadLine());
            double priceOfLightSaber = double.Parse(Console.ReadLine());
            double priceOfRober = double.Parse(Console.ReadLine());
            double priceOfbelt = double.Parse(Console.ReadLine());

            //We ca get every six with out loop-->
            //everySix = studenCount - (studentCount / 6);
            double priceForBeltsWithoutEverySix = studentCount;
            for (int i = 1; i <= studentCount; i++)
            {
                if (i % 6 == 0)
                {
                    priceForBeltsWithoutEverySix--;
                }
            }

            double tenPercentMoreForLightSaber = Math.Ceiling((double)studentCount * 10 / 100);
            double priceOfAllLightSaber = priceOfLightSaber 
                * (studentCount + tenPercentMoreForLightSaber); ;
            double priceOfAllRober = priceOfRober * studentCount;
            double priceOfAllbelt = priceOfbelt * priceForBeltsWithoutEverySix;

            double totalPrice = priceOfAllbelt + priceOfAllLightSaber + priceOfAllRober;

            if (totalPrice <= money)
            {
                Console.WriteLine($"The money is enough - it would cost {totalPrice:F2}lv.");
            }
            else
            {
                double neededMoney = totalPrice - money;
                Console.WriteLine($"George Lucas will need {neededMoney:F2}lv more.");
            }
        }
    }
}
