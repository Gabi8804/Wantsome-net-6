﻿using StoreApp.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApp.DataAccess
{
   public class AddressRepository<Address>
    {
        private readonly SmartStoreDBEntities db;

        public AddressRepository()
        {
            db = new SmartStoreDBEntities();
        }

        public int CreateAddressandGetId(Entities.Address address)
        {
            db.Address.Add(address);
            db.SaveChanges();
            return address.AddressId;
        }
    }
}
