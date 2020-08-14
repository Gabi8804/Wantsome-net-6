using System;

namespace HotelApp
{
    public class Rate
    {
        public int Ammount { get; private set; }
        public string Currency { get; private set; }



        public Rate(string currency, int ammount)
        {
            this.Currency = currency;
            this.Ammount = ammount;
        }

        public void Print()
        {
            Console.WriteLine($"The room costs: {Ammount} {Currency}");
        }

    }
}