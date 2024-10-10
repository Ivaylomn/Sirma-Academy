namespace _01.SumFirstAndLastElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(",").Select(int.Parse).ToArray();

            int sumFirstAndLastElement = arr[0] + arr[arr.Length - 1];

            Console.WriteLine(sumFirstAndLastElement);
        }
    }
}
