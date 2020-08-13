using System;

namespace HotelApp
{
    public class Rate
    {
        public int ammount { get; set; }
        public string currency { get; set; }



        public Rate(string currency, int ammount)
        {
            this.currency = currency;
            this.ammount = ammount;
        }

        public void Print()
        {
            Console.WriteLine($"The room costs: {ammount} {currency}");
        }

    }
}