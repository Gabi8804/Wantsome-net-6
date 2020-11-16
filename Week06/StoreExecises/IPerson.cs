using System;
using System.Collections.Generic;
using System.Text;

namespace StoreExecises
{
    interface IPerson
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        int Age { get; set; }
    }
}
