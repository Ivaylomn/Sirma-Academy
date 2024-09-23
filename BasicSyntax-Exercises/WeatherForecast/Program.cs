namespace WeatherForecast
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            int degrees = int.Parse(Console.ReadLine());

            Console.WriteLine($"Today in {city} it is {degrees} degrees.");
        }
    }
}
