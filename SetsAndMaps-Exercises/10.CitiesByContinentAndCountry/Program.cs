namespace _10.CitiesByContinentAndCountry
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, List<string>>> dict = new Dictionary<string, Dictionary<string, List<string>>>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string continent = input[0];
                string country = input[1];
                string city = input[2];

                if (!dict.ContainsKey(continent))
                {
                    dict.Add(continent, new Dictionary<string, List<string>>());
                }

                if (!dict[continent].ContainsKey(country))
                {
                    dict[continent].Add(country, new List<string>());
                }

                dict[continent][country].Add(city);
            }

            foreach (var continetn in dict)
            {
                Console.WriteLine($"{continetn.Key}:");
                foreach (var countries in continetn.Value)
                {
                    Console.WriteLine($" {countries.Key} -> {string.Join(", ", countries.Value)}");
                }
            }
        }
    }
}
