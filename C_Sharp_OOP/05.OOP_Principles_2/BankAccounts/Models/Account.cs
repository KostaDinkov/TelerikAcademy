using BankAccounts.Contracts;

namespace BankAccounts.Models
{
    public abstract class Account
    {
        public ICustomer Customer { get; set; }
        public decimal Balance { get; set; }
        public decimal InterestRate { get; set; }

        public abstract decimal CalculateInterest(int months);




    }
}