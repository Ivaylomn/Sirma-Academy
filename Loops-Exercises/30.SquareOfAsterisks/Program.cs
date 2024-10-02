namespace _16.HollowRectanglePattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    Console.Write('*' + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
