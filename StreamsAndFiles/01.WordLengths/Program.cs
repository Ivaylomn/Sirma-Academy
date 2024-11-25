namespace _01.WordLengths
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputPath = @"D:\Ivaylo\Sirma-Academy\Educational-Resources\OOP\StreamsAndFiles\01.WordLengths\Input.text";
            string outputPath = @"D:\Ivaylo\Sirma-Academy\Educational-Resources\OOP\StreamsAndFiles\01.WordLengths\Output.txt";

            using StreamReader reader = new StreamReader(inputPath);
            string[] text = reader.ReadLine().Split().ToArray();

            List<int> numbers = new List<int>();

            while (reader.EndOfStream)
            {
                foreach (var word in text)
                {
                    numbers.Add(word.Length);
                }
            }

            using StreamWriter writer = new StreamWriter(outputPath);
            writer.Write(numbers.ToArray());
        }
    }
}
