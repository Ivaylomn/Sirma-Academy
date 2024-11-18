namespace _03.CountSymbols
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            Dictionary<char, int> dict = new Dictionary<char, int>();

            for (int i = 0; i < text.Length; i++)
            {
                char currentElement = text[i];
                if (!dict.ContainsKey(currentElement))
                {
                    dict.Add(currentElement, 0);
                }

                dict[currentElement]++;
            }

            foreach (var item in dict.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
