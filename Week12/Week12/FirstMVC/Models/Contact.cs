using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FirstMVC.Models
{
    public class Contact
    {
        public string Name { get; set; }
    }

    public class ContactManager
    {
        public Contact GetContactData()
        {
            return new Contact { Name = "Gabriel" };
        }
    }
}