using System;

namespace ClassesCodeChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            bool IsSuccessful = true;

            // Create the Checking Account with initial balance
            CheckingAcct checking = new CheckingAcct("John", "Doe", 2500.0m);
            IsSuccessful &= (checking.Balance == 2500.0m);
            IsSuccessful &= (checking.AccountOwner == "John Doe");

            // Create the Savings Account with interest and initial balance
            SavingsAcct saving = new SavingsAcct("Jane", "Doe", 0.03m, 1000.0m);
            IsSuccessful &= (saving.Balance == 1000.0m);
            IsSuccessful &= (saving.AccountOwner == "Jane Doe");

            // Deposit money
            checking.Deposit(200.0m);
            saving.Deposit(150.0m);
            IsSuccessful &= (checking.Balance == 2700.0m);
            IsSuccessful &= (saving.Balance == 1150.0m);

            // Withdraw money
            checking.Withdraw(50.0m);
            saving.Withdraw(125.0m);
            IsSuccessful &= (checking.Balance == 2650.0m);
            IsSuccessful &= (saving.Balance == 1025.0m);

            // Apply interest to savings
            saving.ApplyInterest();
            IsSuccessful &= (saving.Balance == 1055.75m);

            // More than three savings withdrawals → $2 charge
            saving.Withdraw(10.0m);
            saving.Withdraw(20.0m);
            saving.Withdraw(30.0m);
            IsSuccessful &= (saving.Balance == 993.75m);

            // Try to overdraw savings (should be denied)
            saving.Withdraw(2000.0m);

            // Overdraw checking (allowed, with overdraft fee)
            checking.Withdraw(3000.0m);
            IsSuccessful &= (saving.Balance == 993.75m);
            IsSuccessful &= (checking.Balance == -385.00m);

            Console.WriteLine(IsSuccessful ? "All tests passed!" : "Some tests failed.");
        }
    }
}