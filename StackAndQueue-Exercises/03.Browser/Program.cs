namespace _03.Browser
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TODO: прегледай задачата на ново!!!
            Stack<string> history = new Stack<string>();
            string currentURL = null;

            string command = Console.ReadLine();

            while (command != "Home")
            {
                if (command == "back")
                {
                    if (history.Count > 0)
                    {
                        currentURL = history.Pop();
                    }
                    else
                    {
                        Console.WriteLine("no previous URLs");
                        command = Console.ReadLine();
                        continue;
                    }
                }
                else
                {
                    if (currentURL != null)
                    {
                        history.Push(currentURL);
                    }
                    currentURL = command;
                }

                Console.WriteLine(currentURL);
                command = Console.ReadLine();
            }
        }
    }
}
