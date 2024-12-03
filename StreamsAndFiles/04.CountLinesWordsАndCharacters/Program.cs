namespace _04.CountLinesWordsАndCharacters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputPath = @"D:\Ivaylo\Sirma-Academy\Educational-Resources\OOP\StreamsAndFiles\04.CountLinesWordsAndCharacters\Input.txt";
            string outputPath = @"D:\Ivaylo\Sirma-Academy\Educational-Resources\OOP\StreamsAndFiles\04.CountLinesWordsAndCharacters\Output.txt";

            using StreamReader reader = new StreamReader(inputPath);

            int lineCount = 0;
            int wordCount = 0;
            int characterCount = 0;

            while (true)
            {
                string line = reader.ReadLine();
                if (line == null)
                {
                    break;
                }
                else
                {
                    characterCount += line.Length;
                    lineCount++;
                }

                string[] text = line.Split();
                wordCount += text.Length;
            }

            using StreamWriter writer = new StreamWriter(outputPath);
            writer.WriteLine($"Lines count is: {lineCount}");
            writer.WriteLine($"Words count is: {wordCount}");
            writer.WriteLine($"Characters count is: {characterCount}");
        }
    }
}
