namespace _09.WordFilter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Solution one with for loops
            //string[] input = Console.ReadLine().Split();
            //List<string> evenWord = new List<string>();

            //foreach (var word in input)
            //{
            //    if (word.Length % 2 == 0)
            //    {
            //        evenWord.Add(word);
            //    }
            //}

            //foreach (var word in evenWord)
            //{
            //    Console.WriteLine(word);
            //}

            //Solution two with LINQ
            string[] input = Console.ReadLine()
                .Split()
                .Where(x => x.Length % 2 == 0)
                .ToArray();

            Console.WriteLine(string.Join(Environment.NewLine, input));
        }
    }
}
