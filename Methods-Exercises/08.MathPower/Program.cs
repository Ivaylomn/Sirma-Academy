namespace _08.MathPower
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            int pow = int.Parse(Console.ReadLine());
            Console.WriteLine(MathPow(number, pow));
        }

        public static double MathPow(double a, int b)
        {
            //return Math.Pow(a, b);
            double result = 1;
            for (int i = 1; i <= b; i++)
            {
                result *= a;
            }

            return result;
        }
    }
}
