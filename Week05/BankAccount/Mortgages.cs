namespace BankAccount
{
    internal class Mortgages : Account, IDeposit
    {
        public void Deposit()
        { 
        }

        protected override double CalculateInterest(int number_of_months)
        {
            if (number_of_months > 12)
            {
                return (base.CalculateInterest(12)) / 2 + base.CalculateInterest(number_of_months-12);
            } else
           return base.CalculateInterest(number_of_months);
        }
    }
}