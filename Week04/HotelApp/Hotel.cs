using System;
using System.Collections.Generic;
using System.Text;

namespace HotelApp
{
    class Hotel
    {
        public string name { get; private set; }
        private string city { get; set; }
        public List<Room> rooms { get; private set; }
        private int priceForNumberOfRooms;
        public static List<Hotel> myHotels { get; private set; }


        public Hotel(string name, string city, List<Room> rooms)
        {
            this.name = name;
            this.city = city;
            this.rooms = rooms;
            foreach (var room in rooms)
            {
                priceForNumberOfRooms += room.rate.ammount;
            }
        }

        
        public void GetPriceForNumberOfRooms(int numberOfRooms)
        {
            Console.WriteLine($"The price for the number of rooms is {priceForNumberOfRooms}");
        }

        public void Print()
        {
            Console.WriteLine($"Hotel name: {name}, City {city}" );
            foreach(var room in rooms)
            {
                room.Print();
            }
        }
    }
}
