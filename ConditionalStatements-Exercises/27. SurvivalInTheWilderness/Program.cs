namespace _27._SurvivalInTheWilderness
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string timeOfDay = Console.ReadLine();
            string environment = Console.ReadLine();
            string item = Console.ReadLine();

            if (timeOfDay == "day" && environment == "forest")
            {
                if (item == "knife")
                {
                    Console.WriteLine("Hunt for food");
                }
                else if (item == "container")
                {
                    Console.WriteLine("Collect berriers");
                }
                else
                {
                    Console.WriteLine("Explore");
                }
            }
            else if (timeOfDay == "day" && environment == "desert")
            {
                if (item == "hat")
                {
                    Console.WriteLine("Search for water");
                }
                else
                {
                    Console.WriteLine("Find shade");
                }
            }
            else if (timeOfDay == "night" && environment == "forest")
            {
                if (item == "firestarter")
                {
                    Console.WriteLine("Make campfire");
                }
                else
                {
                    Console.WriteLine("Climb a tree for safety");
                }
            }
            else if (timeOfDay == "night" && environment == "desert")
            {
                if (item == "blanket")
                {
                    Console.WriteLine("Sleep");
                }
                else
                {
                    Console.WriteLine("Keep mooving to stay warm");
                }
            }
        }
    }
}
