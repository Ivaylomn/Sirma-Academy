using System.Collections.Immutable;

namespace _13.NegativePositiveNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();


            Console.WriteLine(string.Join("\n", array));
        }
    }
}
