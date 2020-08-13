using System;

namespace HotelApp
{
    internal class Room
    {
        public string name { get; private set; }
        public Rate rate { get; set; }
        private int adults { get; set; }
        private int children { get; set; }


        public Room(string name, int adults, int children, Rate rate)
        {
            this.name = name;
            this.adults = adults;
            this.children = children;
            this.rate = rate;
        }

        public void GetPriceForDays(int numberOfDays)
        {
            var price = numberOfDays * rate.ammount;
            Console.WriteLine($"Price for the nr of days is: {price}"); ;
        }
        public void Print()
        {
            Console.WriteLine($"Room name: {name}, Nr of Adults {adults}, Nr of Children {children}");
            rate.Print();
            Console.WriteLine("============================");
        }





    }
}