using StoreApp.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApp.DataAccess
{
   public class Prod_CatSpecsRepository<Prod_CatSpec>
    {

        private readonly SmartStoreDBEntities db;

        public Prod_CatSpecsRepository()
        {
            db = new SmartStoreDBEntities();
        }

        public void CreateMultiple(List<Entities.Prod_CatSpec> prod_CatSpecs)
        {
            db.Prod_CatSpec.AddRange(prod_CatSpecs);
            db.SaveChanges();
        }
        public List<Entities.Prod_CatSpec> GetProd_CatSpecsByProductId(int productId)
        {
            return db.Prod_CatSpec.Where(x => x.ProductId == productId).ToList();
        }
    }
}
