using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccount
{
    class Bank
    {
        public List<Deposits> Deposits = new List<Deposits>();
        public List<Loans> Loans = new List<Loans>();
        public List<Mortgages> Mortgages = new List<Mortgages>();
        public ICustomer Customer { get; set; }
    }
}
