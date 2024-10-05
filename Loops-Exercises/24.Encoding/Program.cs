namespace _24.Encoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int numberLenght = number.ToString().Length;

            for (int i = 0; i < numberLenght; i++)
            {
                int getLastDigit = number % 10;
                number /= 10;
                int sumLastDigitWithThirtyThree = getLastDigit + 33;

                if (getLastDigit == 0)
                {
                    Console.WriteLine("ZERO");
                    continue;
                }

                for (int j = 0; j < getLastDigit; j++)
                {
                    char numberAsCharFromASCII = (char)sumLastDigitWithThirtyThree;
                    Console.Write(numberAsCharFromASCII);
                }
                Console.WriteLine();
            }
        }
    }
}
