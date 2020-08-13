using System;

namespace PizzaApp
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaTopping topping1 = new PizzaTopping("Cheese", "Cascaval", 12);
            PizzaTopping topping2 = new PizzaTopping("Meat", "Ham", 17);

            PizzaBase pizzaBase = new PizzaBase("Italian", "Base1", 15);

            Pizza pizza1 = new Pizza(pizzaBase, "Pizza1");

            pizza1.AddTopping(topping1);
            pizza1.AddTopping(topping2);

            pizza1.Print();

        }
    }
}
