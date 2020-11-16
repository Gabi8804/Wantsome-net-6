using System;
using System.Collections.Generic;
using System.Text;

namespace StoreExecises
{
    interface IVehicle
    {
        string ModelName { get; set; }
        int BuildYear { get; set; }
        IProducer Producer { get; set; }
        double Price { get; set; }
    }
}
