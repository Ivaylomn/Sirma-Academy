using System;

class Program
{
    static void Main()
    {
        int minutes = int.Parse(Console.ReadLine());

        // Пресмятане на часове и минути
        int hours = minutes / 60;
        int remainingMinutes = minutes % 60;

        // Форматиране и принтиране в HR:MM формат
        Console.WriteLine($"{hours:D2}:{remainingMinutes:D2}");
    }
}
