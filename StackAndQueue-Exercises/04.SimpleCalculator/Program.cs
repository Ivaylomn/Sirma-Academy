using System;
using System.Collections.Generic;

class SimpleCalculator
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] tokens = input.Split(' ');
        Stack<int> stack = new Stack<int>();

        int i = 0;
        while (i < tokens.Length)
        {
            if (int.TryParse(tokens[i], out int number))
            {
                stack.Push(number);
            }
            else
            {
                string operatorToken = tokens[i];
                i++;
                int nextNumber = int.Parse(tokens[i]);

                if (operatorToken == "+")
                {
                    stack.Push(nextNumber);
                }
                else if (operatorToken == "-")
                {
                    stack.Push(-nextNumber);
                }
            }
            i++;
        }

        int result = 0;
        while (stack.Count > 0)
        {
            result += stack.Pop();
        }

        Console.WriteLine(result);
    }
}
