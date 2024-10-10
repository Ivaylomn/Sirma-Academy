namespace _08.Articles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ").ToArray();
            int n = int.Parse(Console.ReadLine());

            Articles article = new Articles(input[0], input[1], input[2]);
            for (int i = 0; i < n; i++)
            {
                string[] commandArgs = Console.ReadLine().Split(": ").ToArray();

                string action = commandArgs[0];
                switch (action)
                {
                    case "Edit":
                        string content = commandArgs[1];
                        article.Edit(content);
                        break;
                    case "ChangeAuthor":
                        string author = commandArgs[1];
                        article.ChangeAuthor(author);
                        break;
                    case "Rename":
                        string title = commandArgs[1];
                        article.Rename(title);
                        break;
                    default:
                        Console.WriteLine("Invalid command!");
                        break;
                }

            }

            Console.WriteLine(article);
        }
    }
}
