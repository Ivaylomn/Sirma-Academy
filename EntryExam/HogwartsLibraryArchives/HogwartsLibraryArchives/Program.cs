namespace HogwartsLibraryArchives
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(x => x.TrimEnd())
                .ToArray();
            string searchWord = Console.ReadLine();

            if (input.Contains(searchWord))
            {
                bool isLastOccurrence = true;
                int firstOccurrence = -1;
                int lastOccurrence = -1;
                for (int i = 0; i < input.Length; i++)
                {
                    if (searchWord == input[i])
                    {
                        if (firstOccurrence == -1)
                        {
                            firstOccurrence = i;
                        }
                        lastOccurrence = i;
                    }
                }

                Console.WriteLine($"First Occurrence: {firstOccurrence}");
                Console.WriteLine($"Last Occurrence: {lastOccurrence}");
            }
            else
            {
                Console.WriteLine("Record not found");
            }
        }
    }
}
