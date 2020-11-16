namespace BankAccount
{
    internal class Deposits : Account, IDeposit, IWithdraw
    {
        protected override double CalculateInterest(int number_of_months)
        {
            if (!(Balance < 1000 && Balance > 0))
            {
                return base.CalculateInterest(number_of_months);
            }
            else return base.CalculateInterest(0);

        }
        public void Deposit()
        {  
        }

        public void Withdraw()
        {
        }
    }
}