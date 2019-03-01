using System;

namespace ch04_factory
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaStore nyStore = new NYPizzaStore();
            PizzaStore chicagoStore = new ChicagoPizzaStore();

            Pizza pizza = nyStore.orderPizza("cheese");
            System.Console.WriteLine("Ethan ordered a " + pizza.GetName() + "\n");

            pizza = chicagoStore.orderPizza("cheese");
            System.Console.WriteLine("Joel ordered a " + pizza.GetName() + "\n");

        }
    }
}
