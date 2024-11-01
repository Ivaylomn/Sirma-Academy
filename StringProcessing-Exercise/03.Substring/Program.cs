namespace _03.Substring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = Console.ReadLine();
            string text = Console.ReadLine();

            for (int i = 0; i < text.Length; i++)
            {
                int index = text.IndexOf(pattern);
                if (index != -1)
                {
                    text = text.Remove(index, pattern.Length);
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine(text);
        }
    }
}
