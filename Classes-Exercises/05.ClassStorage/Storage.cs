using System.Text;
using System.Text.Json;

namespace _05.ClassStorage
{
    internal class Storage
    {
        private int capacity;
        private List<Product> products = new List<Product>();

        public Storage(int capacity)
        {
            Capacity = capacity;
        }

        public int Capacity
        {
            get { return capacity; }
            set { capacity = value; }
        }

        internal List<Product> Products
        {
            get => products;
            set => products = value;
        }
        public double TotalCost
        {
            get => products.Sum(x => x.Quantity * x.Price);
        }

        public void AddProduct(Product product)
        {
            if (capacity - product.Quantity <= 0)
            {
                Console.WriteLine("You don't have enough storage!");
            }
            else
            {
                products.Add(product);
                capacity -= product.Quantity;
            }
        }

        public string GetProducts()
        {
            //    StringBuilder sb = new StringBuilder();

            //    foreach (var product in products)
            //    {
            //        sb.AppendLine(product.Name);
            //    }

            //    return sb.ToString().Trim();
            string jsonProduct = JsonSerializer.Serialize(Products, new JsonSerializerOptions
            {
                WriteIndented = true
            });

            return jsonProduct;
        }
    }
}
