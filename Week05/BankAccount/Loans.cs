namespace BankAccount
{
    public class Loans : Account, IDeposit
    {
        public void Deposit()
        {
            
        }
        protected override double CalculateInterest(int number_of_months)
        {
            if (number_of_months > 3)
            {
              return base.CalculateInterest(number_of_months - 3);
            }
            else
                return base.CalculateInterest(number_of_months);
        }
    }
}