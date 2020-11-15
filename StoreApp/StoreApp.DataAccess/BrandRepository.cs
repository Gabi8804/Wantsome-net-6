using StoreApp.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApp.DataAccess
{
    public class BrandRepository<Brands>
    {

        private readonly SmartStoreDBEntities db;

        public BrandRepository()
        {
            db = new SmartStoreDBEntities();
        }

        public List<Entities.Brands> ReadByIds(List<int> brandIds)
        {
          return db.Brands.Where(x => brandIds.Contains(x.BrandId)).ToList();
        }

        public List<Entities.Brands> ReadAll()
        {
            return db.Brands.ToList();
        }
    }
}
