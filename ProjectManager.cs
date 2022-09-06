using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_firm
{
    internal class ProjectManager : Manager
    {
        // Private fields because the should only be touched from this class
        private string email;

        // Constructor
        protected internal ProjectManager(string firstName, string lastName, string cprNumber, string telephoneNumber, string email) :
            base(firstName, lastName, cprNumber, telephoneNumber)
        {
            this.email = email;
        }
        // Properties
        private protected string Email { get => email; set { email = value; } }

        // Method for displaying ProjectManager details
        protected internal string PrintProjDetails()
        {
            Console.WriteLine("First name: {0}\nLast name: {1}\nCPR-Number: {2}\nTelephone number: {3}\nEmail: {4}", FirstName, LastName, CPRNumber,TelephoneNumber,email);
            return "";
        }
    }
}
