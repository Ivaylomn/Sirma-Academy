namespace OrderOfThePhoenixVotes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] votes = Console.ReadLine().Split(", ");

            int countOfYes = 0;
            int countOfNo = 0;
            int countOfAbstain = 0;
            foreach (var item in votes)
            {
                if (item == "Yes")
                {
                    countOfYes++;
                }
                else if (item == "No")
                {
                    countOfNo++;
                }
                else if (item == "Abstain")
                {
                    countOfAbstain++;
                }
            }

            string result = string.Empty;
            if (countOfYes > countOfNo)
            {
                result = "Yes";
            }
            else if (countOfNo > countOfYes)
            {
                result = "No";
            }
            else if (countOfAbstain > countOfYes && countOfAbstain >= countOfNo)
            {
                result = "Abstain";
            }
            else
            {
                result = "Tie";
            }

            Console.WriteLine(result);
        }
    }
}
