namespace KilometersToMiles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double kilometers = double.Parse(Console.ReadLine());

            double kilometersToMiles = kilometers * 0.621371192;

            Console.WriteLine(kilometersToMiles);
        }
    }
}
