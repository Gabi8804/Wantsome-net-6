using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalHierarchy
{
    class Kittens:Cat
    {
        //public override string Sex { get { return Sex; }  set { Sex = "Female"; } }

        public Kittens(string name,string sex,int age):base(name,"Female",age)
        {

        }
    }
}
