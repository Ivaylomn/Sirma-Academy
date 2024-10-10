namespace _10.AddAndRemoveElementsFromArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] command = Console.ReadLine().Split(",").ToArray();

            int[] numbers = new int[command.Length];
            int[] numbersCopy = new int[numbers.Length - 1];
            for (int i = 1; i < command.Length; i++)
            {
                if (command[i] == "add")
                {
                    numbers[i - 1] = i;
                }
                else
                {
                    Array.Copy(numbers, numbersCopy, numbersCopy.Length);
                }
            }
        }
    }
}
