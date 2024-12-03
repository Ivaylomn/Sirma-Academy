namespace _01.WordLengths
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputPath = @"D:\Ivaylo\Sirma-Academy\Educational-Resources\OOP\StreamsAndFiles\01.WordLengths\Input.txt";
            string outputPath = @"D:\Ivaylo\Sirma-Academy\Educational-Resources\OOP\StreamsAndFiles\01.WordLengths\Output.txt";

            using StreamReader reader = new StreamReader(inputPath);
            

            List<int> numbers = new List<int>();
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                string[] text = line.Split();
                foreach (var word in text)
                {
                    numbers.Add(word.Length);
                }

            }

            using StreamWriter writer = new StreamWriter(outputPath);
            writer.Write(string.Join(", ", numbers));
        }
    }
}
