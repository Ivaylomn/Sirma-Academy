namespace _01.ReverseNumbersStack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> numbers = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));

            foreach (var item in numbers)
            {
                Console.Write(item + " ");
            }

        }
    }
}
