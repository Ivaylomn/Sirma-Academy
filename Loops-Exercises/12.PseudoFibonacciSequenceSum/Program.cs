using System;

namespace PseudoFibonacciSequenceSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Въвеждаме числото n
            int n = int.Parse(Console.ReadLine());

            // Ако n е 0, директно връщаме 0
            if (n == 0)
            {
                Console.WriteLine(0);
                return;
            }

            // Ако n е 1, директно връщаме 1 (първото число на редицата)
            if (n == 1)
            {
                Console.WriteLine(1);
                return;
            }

            // Начални условия за Фибоначи редицата
            int first = 1;
            int second = 1;
            int sum = first + second;

            // Изчисляваме редицата и сумата на първите n числа
            for (int i = 3; i <= n; i++)
            {
                int next = first + second;
                sum += next;
                first = second;
                second = next;
            }

            Console.WriteLine(sum);
        }
    }
}
