namespace _05.DigitsLettersAndOther
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string digit = "";
            string letter = "";
            string other = "";
            foreach (var item in text)
            {
                if (char.IsLetter(item))
                {
                    letter += item;
                }
                else if (char.IsDigit(item))
                {
                    digit += item;
                }
                else
                {
                    other += item;
                }
            }

            Console.WriteLine(digit);
            Console.WriteLine(letter);
            Console.WriteLine(other);
        }
    }
}
