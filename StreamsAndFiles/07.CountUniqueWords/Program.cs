namespace _07.CountUniqueWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputPath = @"D:\Ivaylo\Sirma-Academy\Educational-Resources\OOP\StreamsAndFiles\07.CountUniqueWords\Input.txt";
            string outputPath = @"D:\Ivaylo\Sirma-Academy\Educational-Resources\OOP\StreamsAndFiles\07.CountUniqueWords\Output.txt";

            using StreamReader reader = new StreamReader(inputPath);
            HashSet<string> words = new HashSet<string>();

            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] text = line
                    .ToLower()
                    .Split()
                    .Select(word => word.Trim(new[] { '.', ',', '!', '?', ';', ':' })) // Премахване на пунктуация
                    .ToArray();

                foreach (var word in text)
                {
                    words.Add(word);
                }
            }

            using StreamWriter writer = new StreamWriter(outputPath);
            writer.WriteLine($"Unique words: {words.Count}");
        }
    }
}
