﻿namespace _01.Marks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double mark = double.Parse(Console.ReadLine());

            if (mark >= 5.50)
            {
                Console.WriteLine("Excellent!");
            }
        }
    }
}
