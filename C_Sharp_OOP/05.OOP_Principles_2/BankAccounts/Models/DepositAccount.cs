using System;
using BankAccounts.Contracts;

namespace BankAccounts.Models
{
    class DepositAccount : Account, IDepositable, IWithdrawable
    {
        

        public void Deposit(decimal ammount)
        {
            this.Balance += ammount;
        }

        public void Withdraw(decimal ammount)
        {
            if (this.Balance - ammount <0)
            {
                throw new InvalidOperationException("Not enough funds!");
            }
            this.Balance -= ammount;
        }

        public override decimal CalculateInterest(int months)
        {
            if(this.Balance>0 && this.Balance < 1000)
            {
                return 0m;
            }
            decimal interest = months * this.InterestRate*this.Balance;
            if (this.Balance<0)
            {
                return -interest;
            }
            return interest;

            
        }
    }
}