namespace _12.ExtractNonDecreasingSubsequenceFromArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            List<int> list = new List<int>();
            list.Add(arr[0]);
            
            int firstBiggestElement = arr[0];
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (firstBiggestElement <= arr[i + 1])
                {
                    firstBiggestElement = arr[i + 1];
                    list.Add(arr[i + 1]);
                }
            }

            Console.WriteLine(string.Join(" ", list));

            //Here I using Array instead of List
            int[] arrTwo = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int[] result = new int[arr.Length];
            int index = 0;

            int currentBiggest = arr[0];
            result[index++] = currentBiggest;

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] >= currentBiggest)
                {
                    currentBiggest = arr[i];
                    result[index++] = arr[i];
                }
            }

            // Премахваме празните елементи от резултата преди печатане
            int[] finalResult = result.Take(index).ToArray();
            Console.WriteLine(string.Join(" ", finalResult));
        }
    }
}
