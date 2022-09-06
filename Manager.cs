using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_firm
{
    internal class Manager : Employee
    {
        // Private fields because the should only be touched from this class
        private string telephoneNumber;

        // Constructor
        protected internal Manager(string firstName, string lastName, string cprNumber, string telephoneNumber) :
            base(firstName, lastName, cprNumber)
        {
            this.telephoneNumber = telephoneNumber;
        }

        // properties
        private protected string TelephoneNumber
        {
            get { return telephoneNumber; }
            set { telephoneNumber = value; } 
        }

        // Method for displaying Manager detials
        protected internal string PrintManDetails()
        {
            Console.WriteLine("First name: {0}\nLast name: {1}\nCPR-Number: {2}\nTelephone number: {3}", FirstName, LastName, CPRNumber, telephoneNumber);
            return "";
        }
    }
}
