using System;
using System.Collections.Generic;
using System.Text;

namespace Simple_PublisherApp.Entities.Interfaces
{
    interface IPublisherManager
    {
        int Create(Publisher publisher);
        int Update(Publisher publisher);
        int Delete(int id);
        Publisher Read(int id);
    }
}
