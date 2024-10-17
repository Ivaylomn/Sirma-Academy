using System.Text;

namespace _07.RepeatString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());

            string repeatedString = RepeatString(text, n);
            Console.WriteLine(repeatedString);
        }

        public static string RepeatString(string text, int n)
        {
            //string repeat = "";
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < n; i++)
            {
                //repeat += text;
                sb.Append(text);
            }

            //return repeat;
            return sb.ToString().TrimEnd();
        }
    }
}
