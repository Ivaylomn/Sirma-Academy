namespace _07.EqualArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arrOne = Console.ReadLine().Split(",").Select(int.Parse).ToArray();
            int[] arrTwo = Console.ReadLine().Split(",").Select(int.Parse).ToArray();

            int sum = 0;
            bool isEqual = true;
            for (int i = 0; i < arrOne.Length; i++)
            {
                if (arrOne[i] == arrTwo[i])
                {
                    sum += arrOne[i];
                }
                else
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    //We can use return and stop program, instead of boolean flag -> true/false!
                    isEqual = false;
                }
            }

            if (isEqual)
            {
                Console.WriteLine(sum);
            }
        }
    }
}
