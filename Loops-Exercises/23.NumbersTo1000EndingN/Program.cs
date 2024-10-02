namespace _23.NumbersTo1000EndingN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = n; i < 1000; i++)
            {
                if (i % 10 == n)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
