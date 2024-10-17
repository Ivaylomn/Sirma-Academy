namespace _11.MathOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOne = int.Parse(Console.ReadLine());
            char @operator = char.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());

            double result = MathOperations(numberOne, @operator, numberTwo);
            Console.WriteLine(Math.Round(result, 2));
        }

        public static double MathOperations(int numberOne, char oper, int numberTwo)
        {
            double result = 0;
            if (oper == '/')
            {
                result = numberOne / numberTwo;
            }
            else if (oper == '*')
            {
                result = numberOne * numberTwo;
            }
            else if (oper == '+')
            {
                result = numberOne + numberTwo;
            }
            else if (oper == '-')
            {
                result = numberOne - numberTwo;
            }

            return result;
        }
    }
}
