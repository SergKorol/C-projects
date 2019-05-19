using System;
namespace BankAccount
{
    public class BankAccount
    {
        public BankAccount()
        {
        }
        public double Money { get; private set; }
        public BankAccount(double cash) { Money = cash; }
        public void Deposit(double inputCash ) { Money += inputCash; }
        public bool Withdraw(double outputCash) 
        {
            if (outputCash > Money)
                return false;
            Money -= outputCash;
            return true;
        }


    }
}
