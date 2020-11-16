using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccount
{
    public abstract class Account
    {
        protected double Interest { get; private set; }
        protected double Balance { get; set; }
        protected double InterestRate { get { return InterestRate; } set { this.InterestRate = 2; } }
        protected ICustomer Customer { get; set; }

        protected virtual double CalculateInterest(int number_of_months)
        {
            return this.Interest = this.InterestRate * number_of_months;
             
        }
    }
}
