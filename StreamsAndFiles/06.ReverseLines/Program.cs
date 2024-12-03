namespace _06.ReverseLines
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputPath = @"D:\Ivaylo\Sirma-Academy\Educational-Resources\OOP\StreamsAndFiles\06.ReverseLines\Input.txt";
            string outputPath = @"D:\Ivaylo\Sirma-Academy\Educational-Resources\OOP\StreamsAndFiles\06.ReverseLines\Output.txt";

            using StreamReader reader = new StreamReader(inputPath);
            using StreamWriter writer = new StreamWriter(outputPath);

            //string result = string.Empty;
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                //for (var i = line.Length - 1; i >= 0; i--)
                //{
                //    result += line[i];
                //}

                string reversedString = new string(line.Reverse().ToArray());
                writer.WriteLine(reversedString);
                //result = string.Empty;
            }
        }
    }
}
