namespace AverageSpeed
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int distance = int.Parse(Console.ReadLine());
            int time = int.Parse(Console.ReadLine());

            int avarageSpeed = distance / time;

            Console.WriteLine($"{avarageSpeed:F2}");
        }
    }
}
