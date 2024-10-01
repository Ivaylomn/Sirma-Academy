namespace _26.PotionBrewingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ingredientOne = Console.ReadLine();
            string ingredientTwo = Console.ReadLine();

            if (ingredientOne == "herbs" || ingredientTwo == "herbs")
            {
                if (ingredientOne == "water" || ingredientTwo == "water")
                {
                    Console.WriteLine("Healtt potion");
                }
                else if (ingredientOne == "oil" || ingredientTwo == "oil")
                {
                    Console.WriteLine("Stealth potion");
                }
                else
                {
                    Console.WriteLine("Minor stamina potion");
                }
            }
            else if (ingredientOne == "berries" || ingredientTwo == "berries")
            {
                if (ingredientOne == "sugar" || ingredientTwo == "sugar")
                {
                    Console.WriteLine("speed potion");
                }
                else
                {
                    Console.WriteLine("Minor energy potion");
                }
            }
            else
            {
                Console.WriteLine("No potion");
            }
        }
    }
}
