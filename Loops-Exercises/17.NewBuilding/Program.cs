﻿namespace _17.NewBuilding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int flors = int.Parse(Console.ReadLine());
            int rooms = int.Parse(Console.ReadLine());

            for (int i = flors; i > 0; i--)
            {
                for (int j = 0; j < rooms; j++)
                {
                    if (i == flors)
                    {
                        Console.Write($"L{i}{j} ");
                    }
                    else if (i % 2 == 0)
                    {
                        Console.Write($"O{i}{j} ");
                    }
                    else
                    {
                        Console.Write($"A{i}{j} ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
