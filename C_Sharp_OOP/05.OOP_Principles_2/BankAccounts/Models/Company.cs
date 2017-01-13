using BankAccounts.Contracts;

namespace BankAccounts.Models
{
    class Company : ICustomer
    {
        public Company(string name, string clientId)
        {

            this.ClientId = Utils.GetUniqueClientID();
        }
        public string Name { get; set; }
        
        public string ClientId { get; set; }
    }
}