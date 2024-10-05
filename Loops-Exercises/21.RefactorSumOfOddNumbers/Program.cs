namespace _21.RefactorSumOfOddNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //This code is writen on JAVA. I must refactor and I using C#
            //Scanner sc = new Scanner(System.in);
            //int n = Integer.parseInt(sc.nextLine());
            //int sum = 1;
            //for (int i = 0; i <= n; i++)
            //{
            //    System.out.print(2 * i + 1);
            //    sum += 2 * i;
            //}
            //System.out.print"Sum: %d%n", sum);

            //This is wrong code from java to C# and now I will refactor code
            //int n = int.Parse(Console.ReadLine());

            //int sum = 1;
            //for (int i = 0; i <= n; i++)
            //{
            //    Console.WriteLine(2 * i + 1);
            //    sum += 2 * i;
            //}
            //Console.WriteLine(sum);

            int n = int.Parse(Console.ReadLine());

            //This is refacred code!
            int sum = 0;
            for (int i = 1; i <= n + n; i++)
            {
                if (i % 2 == 1)
                {
                    sum += i;
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine("Sum:" + sum);
        }
    }
}
