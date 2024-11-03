using System.Text.RegularExpressions;

namespace EpicWizardingDuels
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"(/\\|!!|<>)";

            while (Regex.IsMatch(input, pattern))
            {
                input = Regex.Replace(input, pattern, "");
            }

            if (input.Length == 0)
            {
                Console.WriteLine("Epic");
            }
            else
            {
                Console.WriteLine("Not Epic");
            }
        }
    }


}
