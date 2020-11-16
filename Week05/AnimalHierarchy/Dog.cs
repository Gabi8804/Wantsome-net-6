using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalHierarchy
{
    class Dog:Animal,ISound
    {
        public Dog(string name,string sex,int age):base(name,sex,age)
        {

        }
        public void Sound()
        {
            Console.WriteLine("Ham Ham");
        }
    }
}
