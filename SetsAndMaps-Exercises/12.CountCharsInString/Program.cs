namespace _12.CountCharsInString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<char, int> map = new Dictionary<char, int>();

            foreach (var element in input)
            {
                if (char.IsWhiteSpace(element))
                {
                    continue;
                }

                if (!map.ContainsKey(element))
                {
                    map.Add(element, 0);
                }

                map[element]++;
            }

            foreach (var (key, value) in map)
            {
                Console.WriteLine($"{key} -> {value}");
            }
        }
    }
}
