namespace CircleCircumference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double radius = double.Parse(Console.ReadLine());
            double circumference = 2 * Math.PI * radius;

            Console.WriteLine($"{circumference:F2}");
        }
    }
}
