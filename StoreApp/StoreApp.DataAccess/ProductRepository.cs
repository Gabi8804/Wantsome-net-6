using StoreApp.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApp.DataAccess
{
   public class ProductRepository<Products>
    {
        private readonly SmartStoreDBEntities db;

        public ProductRepository()
        {
            db = new SmartStoreDBEntities();
        }

        public int CreateAndGetId(Entities.Products product)
        {
            db.Products.Add(product);
            db.SaveChanges();
            return product.ProductId;
        }
    }
}
