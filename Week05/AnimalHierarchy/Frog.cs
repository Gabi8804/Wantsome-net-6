using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalHierarchy
{
    class Frog : Animal, ISound
    {
        public Frog(string name,string sex,int age):base(name,sex,age)
        {

        }
        public void Sound()
        {
            Console.WriteLine("Frog");
        }
    }
}
