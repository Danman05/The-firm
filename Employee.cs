using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_firm
{
    internal class Employee
    {
        // Private fields because the should only be touched from this class
        private string firstName;
        private string lastName;
        private string cprNumber;

        // Constructor
        protected internal Employee(string firstName, string lastName, string cprNumber)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.CPRNumber = cprNumber;
        }
        // Properties
        private protected string FirstName { get => firstName; set { firstName = value; } }
        private protected string LastName { get => lastName; set { lastName = value; } }
        private protected string CPRNumber { get => cprNumber; set { cprNumber = value; } }

        // Method for displaying Employee details
        protected internal string PrintEmpDetails()
        {
            Console.WriteLine("First name: {0}\nLast name: {1}\nCPR-Number: {2}",firstName,lastName,cprNumber);
            return "";
        }

    }
}
