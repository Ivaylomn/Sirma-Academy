namespace _20.DaysInMonth
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int monthNumber = int.Parse(Console.ReadLine());

            switch (monthNumber)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    Console.WriteLine(31);
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    Console.WriteLine(30);
                    break;
                case 2:
                    Console.WriteLine(28);
                    break;
            }
        }
    }
}
