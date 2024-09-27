namespace FuelEfficiency
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int distance = int.Parse(Console.ReadLine());
            int fuel = int.Parse(Console.ReadLine());

            int fuelEfficiency = distance / fuel * 10;

            Console.WriteLine(fuelEfficiency);
        }
    }
}
