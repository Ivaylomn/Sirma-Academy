namespace BodyMassIndex_BMI_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double weight = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double bodyMassIndex = weight / Math.Pow(height, 2);

            Console.WriteLine($"{Math.Round(bodyMassIndex, 2)}");
        }
    }
}
