using System;
using System.Collections.Generic;
using System.Text;

namespace StoreExecises
{
    class SkodaStore : Store
    {
        public string Name { get => typeof(SkodaStore).Name; }

        
        public override void CancelOrder(IOrder order, ICustomer customer)
        {
            if (ordersList[customer].Contains(order))
            {
                ordersList[customer].Remove(order);
            }
            else
            {
                Console.WriteLine("No order found");
            }
        }

        public override void ProcessOrder(IOrder order, ICustomer customer)
        {
            order.NumberOfWeeks = new Random().Next();
            if (!ordersList.ContainsKey(customer))
            {
                ordersList.Add(customer, new List<IOrder> { order });
            }
            else
            {
                ordersList[customer].Add(order);
            }
        }
    }
}
