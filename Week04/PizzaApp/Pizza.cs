using System;
using System.Collections.Generic;

namespace PizzaApp
{
    internal class Pizza
    {

        public string name { get; set; }
        public PizzaBase pizzaBase { get; set; }
        public List<PizzaTopping> pizzaToppings { get; set; }

        public Pizza(PizzaBase pizzaBase, string name)
        {
            this.pizzaBase = pizzaBase;
            this.name = name;
            this.pizzaToppings = new List<PizzaTopping>();
        }

        public void AddTopping(PizzaTopping topping)
        {
            this.pizzaToppings.Add(topping);

        }

        public double CalculateTotalCost()
        {
            var sum = 0d;
            sum += this.pizzaBase.cost;

            foreach (var pizzaTopping in this.pizzaToppings)
            {
                sum += pizzaTopping.cost;
            }
            return sum;

        }
        public void Print()
        {
            Console.WriteLine($"Pizza: {this.name}");
            this.pizzaBase.Print();
            foreach (var topping in pizzaToppings)
            {
                topping.Print();
            }
            Console.WriteLine($"Cost: {this.CalculateTotalCost()}");

        }

    }
}