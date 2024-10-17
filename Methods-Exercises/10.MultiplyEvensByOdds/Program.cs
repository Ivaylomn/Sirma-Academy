namespace _10.MultiplyEvensByOdds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(GetSumOfOddAndEvenNumbers(number));
        }

        public static int GetSumOfOddAndEvenNumbers(int number)
        { 
            int oddSum = 0;
            int evenSum = 0;
            while (number > 0)
            {
                int lastNumber = number % 10;
                if (lastNumber % 2 == 0)
                {
                    evenSum += lastNumber;
                }
                else
                {
                    oddSum += lastNumber;
                }
                number /= 10;
            }

            return evenSum * oddSum;
        }
    }
}
