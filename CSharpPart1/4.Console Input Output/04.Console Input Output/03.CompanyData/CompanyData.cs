/*
 * Lecture 4 : Console Input Output
 * Problem 3 : A company has name, address, phone number, 
 *              fax number, web site and manager. The manager 
 *              has first name, last name, age and a phone number. 
 *              Write a program that reads the information about a 
 *              company and its manager and prints them on the console.
 */              

// Note : experimenting with structs a little bit

using System;

class CompanyData
{
    public struct Company       //a data structure to hold the info about the companies
    {
        public string name;
        public string address;
        public long phoneNumber;
        public long faxNumber;
        public string webSite;
        public Manager manager;

    }
    public struct Manager      //a data structure to hold the info for the managers
    {
        public string firstName;
        public string lastName;
        public byte age;
        public long phoneNumber;
    }
    static void Main()
    {
        Company myCompany = new Company(); //create a new instance of the object Company
        Manager myManager = new Manager(); //create a new instance of the object Manager
        
        Console.Write("Enter company's namee: ");
        myCompany.name = Console.ReadLine();
        Console.Write("Enter company's address: ");
        myCompany.address = Console.ReadLine();
        Console.Write("Enter company's phone number: ");
        myCompany.phoneNumber = long.Parse(Console.ReadLine());
        Console.Write("Enter company's fax number: ");
        myCompany.faxNumber = long.Parse(Console.ReadLine());
        Console.Write("Enter company's web site: ");
        myCompany.webSite = Console.ReadLine();
        
        Console.Write("Enter manager's First Name: ");
        myManager.firstName = Console.ReadLine();
        Console.Write("Enter manager's Last Name: ");
        myManager.lastName = Console.ReadLine();
        Console.Write("Enter manager's age: ");
        myManager.age = byte.Parse(Console.ReadLine());
        Console.Write("Enter manager's phone number: ");
        myManager.phoneNumber = long.Parse(Console.ReadLine());
        
        myCompany.manager = myManager;      //The cool part.Set myManager to be the current manager of the company.See more explanation below.

        Console.WriteLine("Company: "+myCompany.name);
        Console.WriteLine("Company's address: "+myCompany.address);
        Console.WriteLine("Company's phone number: "+myCompany.phoneNumber);
        Console.WriteLine("Company's fax number: "+ myCompany.faxNumber);
        Console.WriteLine("Company' s web site: "+ myCompany.webSite);
        Console.WriteLine("Company's manager: "+ myCompany.manager.firstName+" " +myCompany.manager.lastName);
        Console.WriteLine("Manager's age: " + myCompany.manager.age);
        Console.WriteLine("Manager's phone number :" + myCompany.manager.phoneNumber); 
    }

}
/*Note: If we decide to create a new Manager instance and call it newManager,
 *we can give newManager new properties like names, phone etc. then if we use
 *myCompany.manager = newManager, then
 *myCompany.manager.firstName will return the name of newManager and so on.
 *I hope this brings more clarity to the solution i used.
 */

