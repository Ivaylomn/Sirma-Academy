
namespace _06.CalculateRectangleArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());

            int area = RectangleArea(width, length);
            int areaTwo = RectangleAreaTwo(width, length);
            Console.WriteLine(area);
        }

        private static int RectangleArea(int width, int length)
        {
            return width * length;
        }

        //method with arrow expresion
        private static int RectangleAreaTwo(int width, int length)
            => width * length;
    }
}
