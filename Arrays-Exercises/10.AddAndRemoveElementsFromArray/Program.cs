//namespace _10.AddAndRemoveElementsFromArray
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            string[] command = Console.ReadLine().Split(",").ToArray();

//            List<int> list = new List<int>();
//            int count = 1;
//            for (int i = 0; i < command.Length; i++)
//            {
//                if (command[i] == "add")
//                {
//                    list.Add(count);
//                    count++;
//                }
//                else
//                {
//                    if (list.Count > 0)
//                    {
//                        list.RemoveAt(list.Count - 1);
//                    }
//                }
//            }

//            if (list.Count == 0)
//            {
//                Console.WriteLine("Empty");
//            }
//            else
//            {
//                Console.WriteLine(string.Join(" ", list));
//            }
//        }
//    }
//}
using System;

namespace AddRemoveElementsArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Въвеждане на командите
            string[] commands = Console.ReadLine().Split(',');

            // Масив, който ще служи като динамичен (ще го преоразмеряваме)
            int[] numbers = new int[0];

            // Започваме с число 1
            int currentNumber = 1;

            foreach (string command in commands)
            {
                if (command == "add")
                {
                    // Създаваме нов масив с размер +1
                    int[] newArray = new int[numbers.Length + 1];

                    // Копираме старите стойности в новия масив
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        newArray[i] = numbers[i];
                    }

                    // Добавяме новото число на последната позиция
                    newArray[newArray.Length - 1] = currentNumber;

                    // Увеличаваме текущото число след всяка команда
                    currentNumber++;

                    // Присвояваме новия масив на стария
                    numbers = newArray;
                }
                else if (command == "remove" && numbers.Length > 0)
                {
                    // Създаваме нов масив с размер -1
                    int[] newArray = new int[numbers.Length - 1];

                    // Копираме всички елементи освен последния
                    for (int i = 0; i < newArray.Length; i++)
                    {
                        newArray[i] = numbers[i];
                    }

                    // Присвояваме новия масив на стария
                    numbers = newArray;
                }
            }

            if (numbers.Length > 0)
            {
                Console.WriteLine(string.Join(" ", numbers));
            }
            else
            {
                Console.WriteLine("Empty");
            }
        }
    }
}

