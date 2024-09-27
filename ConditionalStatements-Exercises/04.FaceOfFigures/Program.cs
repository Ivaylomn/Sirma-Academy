namespace _04.FaceOfFigures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();

            if (figure == "square")
            {
                double lengthOfSide = double.Parse(Console.ReadLine());
                Console.WriteLine($"{lengthOfSide * lengthOfSide:F2}");
            }
            else if (figure == "rectangle")
            {
                double sideA = double.Parse(Console.ReadLine());
                double sideB= double.Parse(Console.ReadLine());
                Console.WriteLine($"{sideA * sideB:F2}");
            }
            else if (figure == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                double area = Math.PI * Math.Pow(radius, 2);
                Console.WriteLine($"{area:F2}");
            }
            else if (figure == "triangle")
            {
                double lengthOfSide = double.Parse(Console.ReadLine());
                double lengthOHeight = double.Parse(Console.ReadLine());
                double area = 0.5 * lengthOfSide * lengthOHeight;
                Console.WriteLine($"{area:F2}");
            }
        }
    }
}
