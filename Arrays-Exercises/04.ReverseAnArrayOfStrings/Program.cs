namespace _04.ReverseAnArrayOfStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(",").ToArray();

            for (int i = 0; i < arr.Length / 2; i++)
            {
                string temp = arr[i];
                arr[i] = arr[arr.Length - 1 - i];
                arr[arr.Length - 1 - i] = temp;
            }

            Console.WriteLine(string.Join(" ", arr));
            Console.WriteLine(string.Join(" ", arr.Reverse()));
        }
    }
}
