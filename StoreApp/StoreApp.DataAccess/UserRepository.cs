using StoreApp.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApp.DataAccess
{
   public class UserRepository<Users>
    {
        private readonly SmartStoreDBEntities db;

        public UserRepository()
        {
            db = new SmartStoreDBEntities();
        }

        

        public Entities.Users GetByUserName(string userName)
        {
            return db.Users.Where(u => u.UserName == userName).FirstOrDefault();
        }
    }
}
