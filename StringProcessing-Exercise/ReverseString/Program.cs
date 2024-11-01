namespace ReverseString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            while (text != "end")
            {
                string reversedString = "";
                for (int i = text.Length - 1; i >= 0; i--)
                {
                    reversedString += text[i];
                }

                Console.WriteLine($"{text} = {reversedString}");
                text = Console.ReadLine();
            }
        }
    }
}
