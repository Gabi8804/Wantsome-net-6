using StoreApp.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApp.DataAccess
{

    public class CategoryRepository<Categories>
    {

        private readonly SmartStoreDBEntities db;

        public CategoryRepository()
        {
            db = new SmartStoreDBEntities();
        }

        public List<Entities.Categories> ReadByIds(List<int> categoriesIds)
        {
            return db.Categories.Where(x => categoriesIds.Contains(x.CategoryId)).ToList();
        }
    }
}
