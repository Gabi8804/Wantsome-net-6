using System;
using System.Collections.Generic;
using System.Text;

namespace StoreExecises
{
    public abstract class Store
    {
        public Store()
        {
            OrdersList = new Dictionary<ICustomer, List<IOrder>>();
        }

        private Dictionary<ICustomer, List<IOrder>> ordersList;
        string Name { get;  }
        public abstract void ProcessOrder(IOrder order,ICustomer customer);
        public abstract void CancelOrder(IOrder order, ICustomer customer);
        public void AskForDeliveryTime(IOrder order)
        {
            Console.WriteLine("Delivery in: " + order.NumberOfWeeks);
        }
    }
}
