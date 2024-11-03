namespace AurorBattleFormation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(", ").Select(int.Parse).ToList();

            string command = Console.ReadLine();
            while (command != "end")
            {
                string[] commandArgs = command.Split();
                string actoin = commandArgs[0];
                if (actoin == "destroy")
                {
                    int index = int.Parse(commandArgs[1]);
                    if (IsValidIndex(list, index))
                    {
                        list.RemoveAt(index);
                        PrintList(list);
                    }
                }
                else if (actoin == "add")
                {
                    int number = int.Parse(commandArgs[1]);
                    list.Add(number);

                    PrintList(list);
                }
                else if (actoin == "insert")
                {
                    int number = int.Parse(commandArgs[1]);
                    int index = int.Parse(commandArgs[2]);
                    if (index >= 0 && index <= list.Count)
                    {
                        list.Insert(index, number);
                        PrintList(list);
                    }
                }
                else if (actoin == "center")
                {
                    int count = list.Count;
                    if (count % 2 == 0)
                    {
                        int middleIndexOne = (count / 2) - 1;
                        int middleIndexTwo = middleIndexOne + 1;
                        Console.WriteLine($"{list[middleIndexOne]} {list[middleIndexTwo]}");
                    }
                    else
                    {
                        int middleIndex = count / 2;
                        Console.WriteLine(list[middleIndex]);
                    }
                }
                else if (actoin == "swap")
                {
                    int indexOne = int.Parse(commandArgs[1]);
                    int indexTwo = int.Parse(commandArgs[2]);
                    if (indexOne >= 0 && indexOne < list.Count && indexTwo >= 0 && indexTwo < list.Count)
                    {
                        int temp = list[indexOne];
                        list[indexOne] = list[indexTwo];
                        list[indexTwo] = temp;

                        PrintList(list);
                    }
                }

                command = Console.ReadLine();
            }
        }

        public static bool IsValidIndex(List<int> list, int index)
        {
            return index >= 0 && index < list.Count;
        }

        public static void PrintList(List<int> list)
        {
            Console.WriteLine(string.Join(" ", list));
        }
    }
}
