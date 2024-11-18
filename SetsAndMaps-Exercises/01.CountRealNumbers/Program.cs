namespace _01.CountRealNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] input = Console.ReadLine().Split().Select(double.Parse).ToArray();
            Dictionary<double, int> result = new Dictionary<double, int>();

            for (int i = 0; i < input.Length; i++)
            {
                double currentElement = input[i];
                if (!result.ContainsKey(currentElement))
                {
                    result.Add(currentElement, 0);
                }

                result[currentElement]++;
            }

            foreach (var item in result)
            {
                Console.WriteLine($"{item.Key:F1} -> {item.Value}");
            }
        }
    }
}
