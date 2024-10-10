using System.Text.Json;

namespace _05.ClassStorage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product productOne = new Product("Krastavica", 1.50, 15);
            Product productTwo = new Product("domat", 0.90, 25);
            Product productThree = new Product("luk", 1.10, 8);

            Storage storage = new Storage(50);
            storage.AddProduct(productOne);
            storage.AddProduct(productTwo);
            storage.AddProduct(productThree);

            Console.WriteLine(storage.GetProducts()); 
            Console.WriteLine(storage.Capacity);
            Console.WriteLine(storage.TotalCost);
        }
    }
}
