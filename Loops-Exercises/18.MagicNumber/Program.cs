namespace _18.MagicNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());

            int count = 1;
            bool isMagicNumber = false;
            for (int i = start; i <= end; i++)
            {
                for (int j = start; j <= end; j++)
                {
                    int sum = i + j;
                    if (sum == magicNumber)
                    {
                        Console.WriteLine($"Combination {count} - ({i} + {j} = {magicNumber})");
                        isMagicNumber = true;
                        break;
                    }
                    count++;
                }

                if (isMagicNumber)
                {
                    break;
                }
            }
            if (!isMagicNumber)
            {
                Console.WriteLine($"{count - 1} combinations - neither equals {magicNumber}");
            }
        }
    }
}
