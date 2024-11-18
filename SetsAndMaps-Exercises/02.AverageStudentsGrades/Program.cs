namespace _02.AverageStudentsGrades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            SortedDictionary<string, List<double>> studentInformation = new SortedDictionary<string, List<double>>();

            for (int i = 0; i < n; i++)
            {
                string[] nameAndGrade = Console.ReadLine().Split();
                string name = nameAndGrade[0];
                double grade = double.Parse(nameAndGrade[1]);

                if (!studentInformation.ContainsKey(name))
                {
                    studentInformation.Add(name, new List<double>());
                }

                studentInformation[name].Add(grade);
            }

            foreach (var item in studentInformation)
            {
                Console.Write($"{item.Key} -> ");

                //string.Join(" ", item.Value.Select(g => g.ToString("F2"))
                foreach (var grade in item.Value)
                {
                    Console.Write($"{grade:f2} ");
                }
                                          //Or We can use method average: item.Value.Average()
                Console.WriteLine($"(avg: {item.Value.Sum() / item.Value.Count():F2})");

            }
        }
    }
}
