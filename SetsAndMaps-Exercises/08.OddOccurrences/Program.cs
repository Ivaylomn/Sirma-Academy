namespace _08.OddOccurrences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            Dictionary<string, int> count = new Dictionary<string, int>();

            foreach (var item in input)
            {
                string currentElement = item.ToLower();
                if (!count.ContainsKey(currentElement))
                {
                    count.Add(currentElement, 0);
                }

                count[currentElement]++;
            }

            count = count
                .Where(x => x.Value % 2 == 1)
                .ToDictionary(x => x.Key, x => x.Value);

            Console.WriteLine(string.Join(", ", count.Keys));
        }
    }
}
