namespace _09.PrintEveryN_thElementFromArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine().Split(",").ToArray();
            int step = int.Parse(Console.ReadLine());

            for (int i = 0; i < numbers.Length; i += step)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
