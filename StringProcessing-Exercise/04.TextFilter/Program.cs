namespace _04.TextFilter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] banList = Console.ReadLine().Split(", ").ToArray();
            string text = Console.ReadLine();

            foreach (var item in banList)
            {
                if (text.Contains(item))
                {
                    text = text.Replace(item, new string('*', item.Length));
                }
            }

            Console.WriteLine(text);
        }
    }
}
