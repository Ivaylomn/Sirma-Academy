namespace _16.AtSea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dayToStay = int.Parse(Console.ReadLine()) - 1;
            string typeOfRoom = Console.ReadLine();
            string assessment = Console.ReadLine();

            double price = 0;
            if (dayToStay < 10)
            {
                if (typeOfRoom == "apartment")
                {
                    price = dayToStay * 50;
                    price -= price * 30 / 100;
                }
                else if (typeOfRoom == "presidential")
                {
                    price = dayToStay * 100;
                    price -= price * 10 / 100;
                }
                else
                {
                    price = dayToStay * 25;
                }
            }
            else if (dayToStay >= 10 && dayToStay <= 15)
            {
                if (typeOfRoom == "apartment")
                {
                    price = dayToStay * 50;
                    price -= price * 35 / 100;
                }
                else if (typeOfRoom == "presidential")
                {
                    price = dayToStay * 100;
                    price -= price * 15 / 100;
                }
                else
                {
                    price = dayToStay * 25;
                }
            }
            else if (dayToStay >= 15)
            {
                if (typeOfRoom == "apartment")
                {
                    price = dayToStay * 50;
                    price -= price * 50 / 100;
                }
                else if (typeOfRoom == "presidential")
                {
                    price = dayToStay * 100;
                    price -= price * 20 / 100;
                }
                else
                {
                    price = dayToStay * 25;
                }
            }

            if (assessment == "positive")
            {
                price += price * 25 / 100;
            }
            else
            {
                price -= price * 10 / 100;
            }

            Console.WriteLine($"{price:F2}");
        }
    }
}
