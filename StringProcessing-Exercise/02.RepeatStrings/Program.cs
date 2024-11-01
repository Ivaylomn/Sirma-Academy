namespace _02.RepeatStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().ToArray();

            for (int i = 0; i < input.Length; i++)
            {
                int currentElementLenght = input[i].Length;
                for (int j = 0; j < currentElementLenght; j++)
                {
                    Console.Write(input[i]);
                }
            }
        }
    }
}
