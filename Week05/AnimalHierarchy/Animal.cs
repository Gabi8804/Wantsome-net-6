using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalHierarchy
{
    public abstract class Animal
    {
        public string Name { get; set; }
        public virtual string Sex { get; set; }
        public int Age { get; set; }

        public Animal(string name, string sex,int age)
        {
            this.Name = name;
            this.Sex = sex;
            this.Age = age;
        }
        
    }
}
