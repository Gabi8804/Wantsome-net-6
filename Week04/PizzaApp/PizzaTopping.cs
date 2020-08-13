using System;

namespace PizzaApp
{
    internal class PizzaTopping
    {
        public string name { get; set; }
        public int cost { get; set; }
        public string type { get; set; }

        public PizzaTopping(string type, string name, int cost)
        {
            this.type = type;
            this.name = name;
            this.cost = cost;
        }

        public void Print()
        {
            if (this.type == "Meat")
            {
                Console.WriteLine($"Topping Name: {this.name.ToUpper()}");
            }
            else
            {
                Console.WriteLine($"Topping Name: {this.name}");
            }
        }
    }
}