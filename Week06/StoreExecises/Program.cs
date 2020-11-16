using System;

namespace StoreExecises
{
    class Program
    {
        static void Main(string[] args)
        {
            
            IPerson alex = new NaturalCustomer("Alex","Popescu",30);
            ICustomer alexAutoConsult = new JuridicalCustomer(alex, "alexAutoConsult");

            Store fordStore = new FordStore();

            IVehicle fordVehicle = new FordFocus(2016, 15000);

            IOrder order1 = new Order(fordVehicle, alexAutoConsult);

            fordStore.ProcessOrder(order1, alexAutoConsult);
            fordStore.AskForDeliveryTime(order1);

            IVehicle skoda = new SkodaOctavia(2017, 17000);
            IOrder order2 = new Order(skoda, alexAutoConsult);
            SkodaStore.pro
        }
    }
}
