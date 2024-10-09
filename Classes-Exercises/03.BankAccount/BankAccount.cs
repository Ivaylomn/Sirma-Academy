using System.Runtime.CompilerServices;

namespace _03.BankAccount
{
    internal class BankAccount
    {
        private int id;
        private double balance;
        private static double interestRate = 0.02;

        public int Id { get => id; set => id = value; }

        public static void SetInterestRate(double interest)
        {
            interestRate = interest;
        }

        public double GetInterest(int years)
        {
            return this.balance * interestRate * years;
        }

        public void Deposit(double amount) 
        {
            this.balance += amount;
        }
    }
}
