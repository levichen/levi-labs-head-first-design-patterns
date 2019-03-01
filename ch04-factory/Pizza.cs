using System.Collections.Generic;
using ch04_factory.Ingredient;

namespace ch04_factory
{
    public abstract class Pizza
    {
        protected string name;
        protected Dough dough;
        protected Sauce sauce;
        protected Veggies veggies;
        protected Cheese cheese;
        protected Pepperoni pepperoni;
        protected Clams clam;
        // protected List<string> toppings = new List<string>();

        // public void prepare()
        // {
        //     System.Console.WriteLine("Preparing " + name);
        //     System.Console.WriteLine("Tossing dough...");
        //     System.Console.WriteLine("Adding sauce...");
        //     System.Console.WriteLine("Adding toppings");

        //     foreach (string topping in toppings)
        //     {
        //         System.Console.WriteLine("  " + topping);
        //     }
        // }

        public abstract void prepare();

        public void bake()
        {
            System.Console.WriteLine("Bake for 25 mins at 350c");
        }

        public void cut()
        {
            System.Console.WriteLine("Cutting the pizza into diagonal slices");
        }

        public void box()
        {
            System.Console.WriteLine("Place pizza in offcial PizzaStore box");
        }

        public string GetName()
        {
            return this.name;
        }

        public void SetName(string name)
        {
            this.name = name;
        }
    }
}