namespace _16.ProcessOddNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().
                Split(", ")
                .Select(int.Parse).ToArray();

            int oddCountIndex = 0;
            //We can get oddIndex with / =>
            //int oddCount = arr.Length / 2;
            for (int i = 0; i < arr.Length; i++)
            {
                if (i % 2 == 1)
                {
                    oddCountIndex++;
                }
            }

            int[] oddNumbers = new int[oddCountIndex];
            int index = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (i % 2 == 1)
                {
                    oddNumbers[index++] = arr[i] * 2;
                }
            }

            Console.WriteLine(string.Join(" ", oddNumbers.Reverse()));
        }
    }
}
