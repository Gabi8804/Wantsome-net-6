using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalHierarchy
{
    internal class Cat : Animal, ISound
    {
        //public override string Sex { get; set; }
        public void Sound()
        {
            Console.WriteLine("Meow");
        }

        public Cat(string name,string sex,int age):base(name,sex,age)
        {
        }

        
    }
}
