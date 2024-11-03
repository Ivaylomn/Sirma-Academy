namespace CountingDementor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());

            int totalDomentors = n;
            for (int i = 1; i < h; i++)
            {
                totalDomentors += n + i * m;
            }

            Console.WriteLine(totalDomentors);
        }
    }
}
