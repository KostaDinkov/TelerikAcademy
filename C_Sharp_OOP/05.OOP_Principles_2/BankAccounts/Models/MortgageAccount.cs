using System;
using BankAccounts.Contracts;

namespace BankAccounts.Models
{
    class MortgageAccount : Account, IDepositable
    {
        public void Deposit(decimal ammount)
        {
        }

        public override decimal CalculateInterest(int months)
        {
            if (months < 0)
            {
                throw new ArgumentException();
            }
            decimal interest = 0;
            if (this.Customer is Individual)
            {
                interest = this.CalculateMortgageInterest(months, 6, 0.5m);
            }
            else
            {
                interest = this.CalculateMortgageInterest(months, 12, 0.5m);
            }
            return interest;
        }

        private decimal CalculateMortgageInterest(int months, int gratisPeriod, decimal gratisPeriodDiscount)
        {
            decimal interest = 0;
            int monthsAfterGratis = months - gratisPeriod;
            if (months > gratisPeriod)
            {
                interest = (this.InterestRate * this.Balance * gratisPeriod * gratisPeriodDiscount) +
                           (this.InterestRate * this.Balance * monthsAfterGratis);
            }
            else
            {
                interest = (this.InterestRate * this.Balance * months * gratisPeriodDiscount);
            }
            return interest;
        }
    }
}