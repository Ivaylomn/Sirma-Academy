namespace Printing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            char symbol = char.Parse(Console.ReadLine());
            int numberTypeInteger = int.Parse(Console.ReadLine());
            double numberTypeDouble = double.Parse(Console.ReadLine());

            Console.WriteLine(text + symbol + numberTypeInteger + numberTypeDouble);
        }
    }
}
