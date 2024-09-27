namespace _07.Speed
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double speed = double.Parse(Console.ReadLine());

            if (speed <= 10)
            {
                Console.WriteLine("slow");
            }
            else if (speed > 10 && speed <= 60)
            {
                Console.WriteLine("average");
            }
            else if (speed > 60 && speed <= 120)
            {
                Console.WriteLine("fast");
            }
            else if (speed > 120 && speed <= 160)
            {
                Console.WriteLine("super-fast");
            }
            else if (speed > 160)
            {
                Console.WriteLine("turbo-fast");
            }
        }
    }
}
