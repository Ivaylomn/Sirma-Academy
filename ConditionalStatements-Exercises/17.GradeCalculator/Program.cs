using System.Threading.Channels;

namespace _17.GradeCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int percentagescore = int.Parse(Console.ReadLine());

            if (percentagescore >= 0 && percentagescore < 60)
            {
                Console.WriteLine('F');
            }
            else if (percentagescore >= 60 && percentagescore < 70)
            {
                Console.WriteLine('D');
            }
            else if (percentagescore >= 70 && percentagescore < 80)
            {
                Console.WriteLine('C');
            }
            else if (percentagescore >= 80 && percentagescore < 90)
            {
                Console.WriteLine('B');
            }
            else if (percentagescore >= 90 && percentagescore <= 100)
            {
                Console.WriteLine('A');
            }
            else
            {
                Console.WriteLine("Invalid Input!");
            }
        }
    }
}
