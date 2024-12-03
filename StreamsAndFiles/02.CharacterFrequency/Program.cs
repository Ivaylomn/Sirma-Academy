namespace _02.CharacterFrequency
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputPath = @"D:\Ivaylo\Sirma-Academy\Educational-Resources\OOP\StreamsAndFiles\02.CharacterFrequency\Input.txt";
            string outputPath = @"D:\Ivaylo\Sirma-Academy\Educational-Resources\OOP\StreamsAndFiles\02.CharacterFrequency\Output.txt";

            using StreamReader reader = new StreamReader(inputPath);
            string text = reader.ReadToEnd();

            Dictionary<char, int> keyValues = new Dictionary<char, int>();
            foreach (var item in text)
            {
                if (!keyValues.ContainsKey(item))
                {
                    keyValues.Add(item, 0);
                }

                keyValues[item]++;  
            }

            using StreamWriter writer = new StreamWriter(outputPath);
            foreach (var item in keyValues)
            {
                writer.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
