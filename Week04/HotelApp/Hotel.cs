using System;
using System.Collections.Generic;
using System.Text;

namespace HotelApp
{
    class Hotel
    {
        public string Name { get; private set; }
        private string City { get; set; }
        public List<Room> Rooms { get; private set; }
        private int priceForNumberOfRooms;
        //public static List<Hotel> myHotels { get; private set; }


        public Hotel(string name, string city, List<Room> rooms)
        {
            this.Name = name;
            this.City = city;
            this.Rooms = rooms;  
        }

        
        public void GetPriceForNumberOfRooms(int numberOfRooms)
        {
            for (int i = 0; i < numberOfRooms; i++)
            {
                priceForNumberOfRooms += Rooms[i].rate.Ammount;
            }
            Console.WriteLine($"The price for the number of rooms is {priceForNumberOfRooms}");
            
        }

        public void Print()
        {
            Console.WriteLine($"Hotel name: {Name}, City {City}" );
            foreach(var room in Rooms)
            {
                room.Print();
            }
        }
    }
}
