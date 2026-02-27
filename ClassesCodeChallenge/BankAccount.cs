using System;

namespace ClassesCodeChallenge
{
    // Base class representing a generic bank account
    public class BankAccount
    {
        private string _firstname;
        private string _lastname;

        // Protected setter allows derived classes to modify balance safely
        public decimal Balance { get; protected set; }

        // Constructor initializes account owner and starting balance
        public BankAccount(string fname, string lname, decimal initial = 0.0m)
        {
            _firstname = fname;
            _lastname = lname;
            Balance = initial;
        }

        // Read-only property combining first and last name
        public string AccountOwner => $"{_firstname} {_lastname}";

        // Add funds to the account
        public virtual void Deposit(decimal amount)
        {
            Balance += amount;
        }

        // Basic withdraw behavior (no overdraft allowed)
        public virtual void Withdraw(decimal amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
            }
        }
    }
}