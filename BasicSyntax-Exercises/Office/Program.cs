namespace Office
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double priceForFirstCabinet = double.Parse(Console.ReadLine());

            double priceForSecondCabinet = priceForFirstCabinet - priceForFirstCabinet * 20 / 100;
            double priceForFirstTwoCabinets = priceForFirstCabinet + priceForSecondCabinet;
            double priceForThirdCabinet = priceForFirstTwoCabinets + priceForFirstTwoCabinets * 15 / 100;

            double totalPrice = priceForFirstCabinet + priceForSecondCabinet + priceForThirdCabinet;

            Console.WriteLine($"{totalPrice:F3}");
        }
    }
}
