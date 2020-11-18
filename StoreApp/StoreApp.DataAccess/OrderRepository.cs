using StoreApp.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApp.DataAccess
{
   public class OrderRepository<Orders>
    {

        private readonly SmartStoreDBEntities db;

        public OrderRepository()
        {
            db = new SmartStoreDBEntities();
        }

        public int CreateAddressandGetId(Entities.Orders order)
        {
            db.Orders.Add(order);
            db.SaveChanges();
            return order.OrderId;
        }
    }
}
