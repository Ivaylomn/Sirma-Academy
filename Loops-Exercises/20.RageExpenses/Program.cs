namespace _20.RageExpenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lostGamesCount = int.Parse(Console.ReadLine());
            double headSetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());   
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            int trashesHeadSetCount = 0;
            int trashesMouseCount = 0;
            int trashesKeyboardCount = 0;
            int trashesDisplayCount = 0;
            for (int i = 1; i <= lostGamesCount; i++)
            {
                if (i % 2 == 0)
                {
                    trashesHeadSetCount++;
                }
                if (i % 3 == 0)
                {
                    trashesMouseCount++;
                }
                if (i % 2 == 0 && i % 3 == 0)
                {
                    trashesKeyboardCount++;
                    if (trashesKeyboardCount % 2 == 0)
                    {
                        trashesDisplayCount++;
                    }
                }
                
            }

            double totalExpensses = trashesHeadSetCount * headSetPrice 
                + trashesMouseCount * mousePrice + trashesKeyboardCount * keyboardPrice 
                + trashesDisplayCount * displayPrice;

            Console.WriteLine($"Rage expenses: {totalExpensses:F2} lv.");


        }
    }
}
