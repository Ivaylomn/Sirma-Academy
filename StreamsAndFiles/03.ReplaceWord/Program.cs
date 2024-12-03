namespace _03.ReplaceWord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputPath = @"D:\Ivaylo\Sirma-Academy\Educational-Resources\OOP\StreamsAndFiles\03.ReplaceWord\Input.txt";
            string outputPath = @"D:\Ivaylo\Sirma-Academy\Educational-Resources\OOP\StreamsAndFiles\03.ReplaceWord\Output.txt";

            using StreamReader reader = new StreamReader(inputPath);

            string[] words = reader.ReadLine().Split(" - ");
            string wordToReplace = words[0];
            string replacementWord = words[1];


            using StreamWriter writer = new StreamWriter(outputPath);
            while (true)
            {
                string line = reader.ReadLine();
                if (line == null)
                {
                    break;
                }

                string result = line.Replace(wordToReplace, replacementWord);
                writer.WriteLine(result);
            }
        }
    }
}
