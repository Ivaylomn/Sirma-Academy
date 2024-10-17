
namespace _09.GreaterOfTwoValues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();

            if (type == "int")
            {
                int numberOne = int.Parse(Console.ReadLine());
                int numberTwo = int.Parse(Console.ReadLine());
                int biggestNumber = GetMax(numberOne, numberTwo);
                Console.WriteLine(biggestNumber);
            }
            else if (type == "string")
            {
                string textOne = Console.ReadLine();
                string textTwo = Console.ReadLine();
                string result = GetMax(textOne, textTwo);
                Console.WriteLine(result);
            }
            else
            {
                char a = char.Parse(Console.ReadLine());
                char b = char.Parse(Console.ReadLine());
                int result = GetMax(a, b);
                Console.WriteLine((char)result);
            }
        }

        private static int GetMax(int numberOne, int numberTwo)
        {
            if (numberOne > numberTwo)
            {
                return numberOne;
            }

            return numberTwo;
        }

        private static string GetMax(string textOne, string textTwo)
        {
            if (textOne.CompareTo(textTwo) > 0)
            {
                return textOne;
            }

            return textTwo;
        }

        private static char GetMax(char a, char b)
        {
            if (a > b)
            {
                return a;
            }

            return b;
        }
    }
}
