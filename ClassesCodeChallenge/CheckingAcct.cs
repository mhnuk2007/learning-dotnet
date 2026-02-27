using System;

namespace ClassesCodeChallenge
{
    // Checking account allows overdraft with a fixed fee
    public class CheckingAcct : BankAccount
    {
        private const decimal OVERDRAW_CHARGE = 35.0m;

        public CheckingAcct(string fname, string lname, decimal initial)
            : base(fname, lname, initial)
        {
        }

        // Override withdrawal to allow overdraft
        public override void Withdraw(decimal amount)
        {
            // Always subtract requested amount
            Balance -= amount;

            // If balance becomes negative, apply overdraft fee
            if (Balance < 0)
            {
                Balance -= OVERDRAW_CHARGE;
            }
        }
    }
}