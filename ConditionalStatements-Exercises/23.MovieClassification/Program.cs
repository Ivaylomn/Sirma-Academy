namespace _23.MovieClassification
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());

            if (age < 13)
            {
                Console.WriteLine("Only U-rated movies.");
            }
            else if (age >= 13 && age < 18)
            {
                Console.WriteLine("U and PG-13 rated movies.");
            }
            else
            {
                Console.WriteLine("All movies.");
            }
        }
    }
}
