namespace Speed
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int distanceInMeters = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int seconds = int.Parse(Console.ReadLine());

            int time = hours * 3600 + minutes * 60 + seconds;
            double speed = (double)distanceInMeters / time;

            Console.WriteLine($"{speed:F6}");
        }
    }
}
