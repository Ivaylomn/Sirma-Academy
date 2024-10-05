namespace _28.PyramidOfNnumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {

                
                for (int j = 1 + 1; j <= i + 1; j++)
                {
                    Console.Write(j + " ");
                    j++;
                }
                Console.WriteLine();
            }
        }
    }
}
