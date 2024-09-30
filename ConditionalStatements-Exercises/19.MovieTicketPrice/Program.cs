namespace _19.MovieTicketPrice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());

            int price = 0;
            if (age >= 0 && age <= 12)
            {
                price = 5;
            }
            else if (age >= 13 && age <=19)
            {
                price = 8;
            }
            else
            {
                price = 10;
            }

            Console.WriteLine($"${price}");
        }
    }
}
