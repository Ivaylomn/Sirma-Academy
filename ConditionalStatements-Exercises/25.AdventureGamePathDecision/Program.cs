namespace _25.AdventureGamePathDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string rightHandTool = Console.ReadLine();
            string leftHandTool = Console.ReadLine();

            if (rightHandTool == "sword" || leftHandTool == "sword")
            {
                if (rightHandTool == "shield" || leftHandTool == "shield")
                {
                    Console.WriteLine("Take the path to the castle.");
                }
                else
                {
                    Console.WriteLine("Take the path to the forest.");
                }
            }
            else if (rightHandTool == "map" || leftHandTool == "map")
            {
                if (rightHandTool == "coins" || leftHandTool == "coins")
                {
                    Console.WriteLine("Go to the town.");
                }
                else
                {
                    Console.WriteLine("Camp.");
                }
            }
            else
            {
                Console.WriteLine("Wander aimlessly.");
            }
        }
    }
}
