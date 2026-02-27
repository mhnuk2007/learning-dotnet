using System;

namespace ClassesCodeChallenge
{
    // Savings account earns interest and limits withdrawals
    public class SavingsAcct : BankAccount
    {
        private int _withdrawCount = 0;

        private const int WITHDRAW_LIMIT = 3;
        private const decimal WITHDRAW_CHARGE = 2.0m;

        // Interest rate stored as decimal (e.g., 0.03 for 3%)
        public decimal InterestRate { get; set; }

        public SavingsAcct(string fname, string lname, decimal interest, decimal initial)
            : base(fname, lname, initial)
        {
            InterestRate = interest;
        }

        // Apply interest to current balance
        public void ApplyInterest()
        {
            Balance += Balance * InterestRate;
        }

        // Override withdrawal rules for savings account
        public override void Withdraw(decimal amount)
        {
            // Deny overdraft attempts
            if (amount > Balance)
            {
                Console.WriteLine("Attempt to overdraw savings - denied");
                return;
            }

            // Perform withdrawal
            base.Withdraw(amount);

            _withdrawCount++;

            // If more than allowed withdrawals, charge extra fee
            if (_withdrawCount > WITHDRAW_LIMIT)
            {
                base.Withdraw(WITHDRAW_CHARGE);
            }
        }
    }
}