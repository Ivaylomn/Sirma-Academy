namespace _15.CollatzConjecture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Console.Write(number + " ");
            while (number > 1)
            {
                if (number % 2 == 0)
                {
                    number /= 2;
                }
                else
                {
                    number *= 3;
                    number++;
                }

                Console.Write(number + " ");
            }
        }
    }
}
