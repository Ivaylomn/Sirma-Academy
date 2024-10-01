namespace _04.Numbers1ToNThroughM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int step = int.Parse(Console.ReadLine());

            for (int i = 1; i < n; i += step)
            {
                Console.WriteLine(i);
            }
        }
    }
}
