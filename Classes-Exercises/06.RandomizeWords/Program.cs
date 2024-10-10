namespace _06.RandomizeWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split().ToList();

            Random random = new Random();

            for (int i = 0; i < list.Count; i++)
            {
                int randomIndex = random.Next(i, list.Count);

                string temp = list[i];
                list[i] = list[randomIndex];
                list[randomIndex] = temp;
            }

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
