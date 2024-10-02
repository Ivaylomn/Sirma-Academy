namespace _11.NumberReversal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            string numberAsString = number.ToString();
            for (int i = numberAsString.Length - 1 ; i >= 0; i--)
            {
                Console.Write(numberAsString[i]);
            }
        }
    }
}
