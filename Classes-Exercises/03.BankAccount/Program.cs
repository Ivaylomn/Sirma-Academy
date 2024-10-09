namespace _03.BankAccount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] command = Console.ReadLine().Split().ToArray();

            List<BankAccount> bankAccounts = new List<BankAccount>();
            int countId = 1;
            while (command[0] != "End")
            {
                if (command[0] == "Create")
                {
                    BankAccount bankAccount = new BankAccount();
                    bankAccount.Id = countId;
                    Console.WriteLine($"Account ID{countId} created");
                    countId++;
                    bankAccounts.Add(bankAccount);
                }
                else if (command[0] == "Deposit")
                {
                    int id = int.Parse(command[1]);
                    double amount = double.Parse(command[2]);
                    BankAccount account = bankAccounts.Where(x => x.Id == id).FirstOrDefault();
                    if (account != null)
                    {
                        account.Deposit(amount);
                        Console.WriteLine($"Deposited {amount} to ID{id}");
                    }
                    else
                    {
                        Console.WriteLine("Account does not exist.");
                    }
                }
                else if (command[0] == "SetInterest")
                {
                    double newInterest = double.Parse(command[1]);
                    BankAccount.SetInterestRate(newInterest);
                }
                else if (command[0] == "GetInterest")
                {
                    int id = int.Parse(command[1]);
                    int years = int.Parse(command[2]);
                    BankAccount account = bankAccounts.Where(x => x.Id == id).FirstOrDefault();
                    if (account != null)
                    {
                        double interestRate = account.GetInterest(years);
                        Console.WriteLine($"{interestRate:F2}");
                    }
                    else
                    {
                        Console.WriteLine("Account does not exist.");
                    }
                    
                }

                command = Console.ReadLine().Split().ToArray();
            }
        }
    }
}
