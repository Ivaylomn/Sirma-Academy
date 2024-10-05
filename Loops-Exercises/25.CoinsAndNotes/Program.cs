namespace _25.CoinsAndNotes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cointOfOneLv = int.Parse(Console.ReadLine());
            int coinOfTwoLv = int.Parse(Console.ReadLine());
            int coinOfFiveLv = int.Parse(Console.ReadLine());
            int targetSum = int.Parse(Console.ReadLine());

            for (int i = 0; i <= cointOfOneLv; i++)
            {
                for (int j = 0; j <= coinOfTwoLv; j++)
                {
                    for (int y = 0; y <= coinOfFiveLv; y++)
                    {
                        int sum = i * 1 + j * 2 + y * 5;

                        if (sum == targetSum)
                        {
                            Console.WriteLine($"{i} * 1 lv. + {j} * 2 lv. + {y} * 5 lv. = {sum} lv.");
                        }
                    }
                }
            }
        }
    }
}
