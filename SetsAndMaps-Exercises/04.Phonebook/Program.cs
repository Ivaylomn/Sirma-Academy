namespace _04.Phonebook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, string> dict = new Dictionary<string, string>();
            while (input != "search")
            {
                string[] inputArgs = input.Split("-");
                string name = inputArgs[0];
                string number = inputArgs[1];

                dict[name] = number;

                input = Console.ReadLine();
            }

            input = Console.ReadLine();
            while (input != "stop")
            {
                if (input.Contains('-'))
                {
                    string[] inputArgs = input.Split("-");
                    string name = inputArgs[0];
                    string number = inputArgs[1];

                    dict[name] = number;
                }
                else
                {
                    if (dict.ContainsKey(input))
                    {
                        Console.WriteLine($"{input} -> {dict[input]}");
                    }
                    else
                    {
                        Console.WriteLine($"Contact {input} not found.");
                    }
                }

                input = Console.ReadLine();
            }
        }
    }
}
