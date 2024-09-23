namespace Calculate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numOne = int.Parse(Console.ReadLine());
            int numTwo = int.Parse(Console.ReadLine());

            int sum = numOne + numTwo;
            int difference = numOne - numTwo;
            int multiplication = numOne * numTwo;
            double avarege = (double)sum / 2;

            Console.WriteLine($"The sum is: {sum}");
            Console.WriteLine($"The difference is: {Math.Abs(difference)}");
            Console.WriteLine($"The product is: {multiplication}");
            Console.WriteLine($"The average is: {avarege:f6}");
        }
    }
}
