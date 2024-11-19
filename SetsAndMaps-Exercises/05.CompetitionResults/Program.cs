using System.Reflection.Metadata;

namespace _05.CompetitionResults
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, int>> dict = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" -> ");
                string name = input[0];
                string discipline = input[1];
                int score = int.Parse(input[2]);

                if (!dict.ContainsKey(name))
                {
                    dict.Add(name, new Dictionary<string, int>());
                }


                if (!dict[name].ContainsKey(discipline))
                {
                    dict[name].Add(discipline, 0);
                }

                dict[name][discipline] = score;
            }

            var sortedDict = dict.OrderByDescending(x => x.Value.Values.Sum());

            foreach (var name in sortedDict)
            {
                Console.WriteLine($"{name.Key}: {name.Value.Values.Sum()}");

                var sortedDiscipline = name.Value.OrderByDescending(x => x.Value);
                foreach (var disciplin in sortedDiscipline)
                {
                    Console.WriteLine($" {disciplin.Key} -> {disciplin.Value}");
                }
            }
        }
    }
}
