namespace _02.BasicStackOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] commands = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int n = commands[0];
            int numbersToPopFromStack = commands[1];
            int x = commands[2];

            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < n; i++)
            {
                stack.Push(numbers[i]);
            }
           
            for (int i = 0; i < numbersToPopFromStack; i++)
            {
                if (stack.Count > 0)
                {
                    stack.Pop();
                }
            }

            bool isContainElement = false;
            if (stack.Contains(x))
            {
                isContainElement = true;
            }

            int smallestElement = int.MaxValue;
            foreach (var item in stack)
            {

                if (item < smallestElement)
                {
                    smallestElement = item;
                }
            }

            if (stack.Count == 0)
            {
                Console.WriteLine(0);
            }
            else if (isContainElement)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(smallestElement);
            }
        }
    }
}
