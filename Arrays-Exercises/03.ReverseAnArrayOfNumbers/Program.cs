namespace _03.ReverseAnArrayOfNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = Console.ReadLine().Split(",").Select(int.Parse).ToArray();

            int[] numbers = new int[n];
            for (int i = 0; i < n; i++)
            {
                numbers[i] = arr[i];
            }

            //Whit Forr-loop
            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();

            //Whit methot Reverse()
            Console.WriteLine(string.Join(" ", numbers.Reverse()));
        }
    }
}
