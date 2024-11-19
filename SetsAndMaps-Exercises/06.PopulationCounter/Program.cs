namespace _06.PopulationCounter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, Dictionary<string, int>> dict = new Dictionary<string, Dictionary<string, int>>();

            while (input != "report")
            {
                string[] inputArgs = input.Split("|");
                string city = inputArgs[0];
                string country = inputArgs[1];
                int population = int.Parse(inputArgs[2]);

                if (!dict.ContainsKey(country))
                {
                    dict.Add(country, new Dictionary<string, int>());
                }

                dict[country].Add(city, population);

                input = Console.ReadLine();
            }

            var sortedDict = dict.OrderByDescending(x => x.Value.Values.Sum());

            foreach (var item in sortedDict)
            {
                Console.WriteLine($"{item.Key} (total population: {item.Value.Values.Sum()})");

                var sortedCities = item.Value.OrderByDescending(x => x.Value).ToList();
                foreach (var city in sortedCities)
                {
                    Console.WriteLine($"=>{city.Key}: {city.Value}");
                }

            }
        }
    }
}
