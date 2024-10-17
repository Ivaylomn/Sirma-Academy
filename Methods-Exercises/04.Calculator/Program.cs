using System.Xml.XPath;

namespace _04.Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int numOne = int.Parse(Console.ReadLine());
            int numTwo = int.Parse(Console.ReadLine());

            if (command == "add")
            {
                Add(numOne, numTwo);
            }
            else if (command == "multiply")
            {
                Multiply(numOne, numTwo);
            }
            else if (command == "subtract")
            {
                Subtract(numOne, numTwo);
            }
            else if (command == "divide")
            {
                Divide(numOne, numTwo);
            }
        }

        public static void Add(int numOne, int numTwo)
        {
            int result = numOne + numTwo;
            Console.WriteLine(result);
        }

        public static void Multiply(int numOne, int numTwo) 
        {
            int result = numOne * numTwo;
            Console.WriteLine(result);
        }

        public static void Subtract(int numOne, int numTwo)
        {
            int result = numOne - numTwo;
            Console.WriteLine(Math.Abs(result));
        }

        public static void Divide(int numOne, int numTwo)
        {
            int result = numOne / numTwo;
            Console.WriteLine(result);
        }
    }
}
