using System;
using BankAccounts.Contracts;

namespace BankAccounts.Models
{
    class Individual:ICustomer
    {
        public Individual()
        {
            this.ClientId = Utils.GetUniqueClientID();
        }
        public string ClientId { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string PersonalID { get; set; }

        public string AddressString { get; set; }
    }

    internal static class Utils
    {
        public static string  GetUniqueClientID()
        {
            return Guid.NewGuid().ToString();
        }
    }
}
