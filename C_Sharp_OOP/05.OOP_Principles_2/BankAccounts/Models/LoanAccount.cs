using BankAccounts.Contracts;

namespace BankAccounts.Models
{
    class LoanAccount : Account, IDepositable
    {
        public void Deposit(decimal ammount)
        {
            this.Balance += ammount;
        }

        public override decimal CalculateInterest(int months)
        {
            decimal interest = 0;
            if (this.Customer is Individual)
            {
                interest = this.CalculateLoanInterest(months, 3);
            }
            else
            {
                interest = this.CalculateLoanInterest(months, 2);
            }
            if (interest < 0)
            {
                return 0;
            }
            return interest;
        }

        private decimal CalculateLoanInterest(int months, int gratisPeriod)
        {
            return this.Balance * this.InterestRate * (months - gratisPeriod);
        }
    }
}