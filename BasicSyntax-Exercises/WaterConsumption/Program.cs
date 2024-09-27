namespace WaterConsumption
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double totalWaterConsumation = double.Parse(Console.ReadLine());
            int numberOfPeople = int.Parse(Console.ReadLine());

            double dailyConsumationPerPerson = totalWaterConsumation / 7 / numberOfPeople;

            Console.WriteLine($"{dailyConsumationPerPerson:F2}");
        }
    }
}
