using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccount
{
    class JuridicalCustomer : IPerson, ICustomer
    {
        public string Name { get ; set; }
        public Account Account { get; set; }


    }
}
