namespace Painting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double paindConsumed = double.Parse(Console.ReadLine());

            double paintPerRoom = paindConsumed / 3;

            double redPaint = paintPerRoom / 13 * 3;
            double yellowPaint = 4 * redPaint;
            double whitePaint = 8 * redPaint;

            Console.WriteLine($"Red: {Math.Round(redPaint, 4)}");
            Console.WriteLine($"Yellow: {Math.Round(yellowPaint, 4)}");
            Console.WriteLine($"White: {Math.Round(whitePaint, 4)}");
        }
    }
}
