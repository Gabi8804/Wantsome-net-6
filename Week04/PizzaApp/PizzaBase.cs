using System;

namespace PizzaApp
{
    internal class PizzaBase
    {

        public string name { get; set; }
        public double cost { get; private set; }
        public string type { get; set; }
        
        //public double Cost
        //{
        //    get
        //    {
        //        if(this.type == "Italian")
        //        {
        //            return this.cost * (double)1.5;
        //        }
        //        return this.cost;
        //    }
        //    set
        //    {
        //        this.cost = value;
        //    }
        //}


        public PizzaBase(string type, string name,double cost)
        {
            this.type = type;
            this.name = name;
            if (this.type == "Italian")
            {
                this.cost= cost * (double)1.5;
            }
            this.cost = cost;
        }

        public void Print()
        {
            Console.WriteLine($"Base of pizza: {this.name}");
        }
    }
}