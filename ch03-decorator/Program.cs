using System;
using ch03_decorator.Coffee;
using ch03_decorator.Condiments;

namespace ch03_decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Beverage beverage = new Espresso();
            System.Console.WriteLine(beverage.getDescription() + " $" + beverage.cost());

            Beverage beverage2 = new DarkRoast();
            beverage2 = new Mocha(beverage2);
            beverage2 = new Mocha(beverage2);
            beverage2 = new Whip(beverage2);

            System.Console.WriteLine(beverage2.getDescription() + " $" + beverage2.cost());
        }
    }
}
