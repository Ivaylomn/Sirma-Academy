﻿namespace _05.ClassStorage
{
    internal class Product
    {
        public Product(string name, double price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public string Name { get; set; } 
        public double Price { get; set; } 
        public int Quantity{ get; set; } 
    }
}