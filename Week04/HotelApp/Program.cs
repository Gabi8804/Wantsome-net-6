using System;
using System.Collections.Generic;

namespace HotelApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Rate rate = new Rate("RON", 200);
            Rate rate2 = new Rate("RON", 90);

            //List<Rate> rates = new List<Rate> { rate, rate2 };

            Room room = new Room("room1", 2, 2, rate);
            Room room2 = new Room("room2", 2, 2, rate);
            Room room3 = new Room("room3", 3, 1, rate2);
            Room room4 = new Room("room4", 1, 2, rate2);

            List<Room> Rooms = new List<Room> { room, room2 };
            List<Room> Rooms2 = new List<Room> { room3, room4 };

            Hotel hotel = new Hotel("Ramada", "Iasi", Rooms);
            Hotel hotel2 = new Hotel("Pleiada", "Iasi", Rooms2);

            List<Hotel> hotels = new List<Hotel>();

            AddHotelToList(hotels, hotel);
            AddHotelToList(hotels, hotel2);
            GetHotelList(hotels);


            GetPriceRoomLower(150, hotels);

            RemoveHotel(hotels, "Ramada");
            GetHotelList(hotels);

        }
        static void GetHotelList(List<Hotel> hotels)
        {
            Console.WriteLine("The list includes the following hotels:");
            foreach (var hotel in hotels)
            {
                hotel.Print();
                Console.WriteLine("============================");
            }
        }
        static void AddHotelToList(List<Hotel> hotels, Hotel hotel)
        {
            hotels.Add(hotel);
        }

        static void RemoveHotel(List<Hotel> hotels, string name)
        {
            for (int i = 0; i < hotels.Count; i++)
            {
                if (hotels[i].name == name)
                {
                    Console.WriteLine("============================");
                    Console.WriteLine($"The Hotel {hotels[i].name} was removed from the list");
                    Console.WriteLine("============================");
                    hotels.RemoveAt(i);
                    break;
                }
            }
        }
        static void GetPriceRoomLower(int price, List<Hotel> hotels)
        {
            var check = new bool();
            var roomlist = new List<string>();
            for (int i = 0; i < hotels.Count; i++)
            {
                for (int j = 0; j < hotels[i].rooms.Count; j++)
                {
                    if (price > hotels[i].rooms[j].rate.ammount)
                    {
                        roomlist.Add(hotels[i].rooms[j].name);
                        check = true;
                    }
                    else check = false;
                }
            }
            if (check == false)
            {
                Console.WriteLine("============================");
                Console.WriteLine("Room not found lower than this price");
                Console.WriteLine("============================");
            }
            else
            {
                Console.WriteLine("============================");
                Console.WriteLine("The rooms with price lower are");
                foreach (var room in roomlist)
                {
                    Console.WriteLine(room);
                }
                Console.WriteLine("============================");
            }
        }

    }
}
