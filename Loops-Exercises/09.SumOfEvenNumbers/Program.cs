namespace _09.SumOfEvenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    sum += 2 * i;
                }
            }

            Console.WriteLine(sum);
        }
    }
}
