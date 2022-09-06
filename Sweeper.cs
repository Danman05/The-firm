using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_firm
{
    internal class Sweeper : Employee
    {
        protected internal Sweeper(string firstName, string lastName, string cprNumber) :
            base(firstName, lastName,cprNumber)
        {

        }
    }
}
