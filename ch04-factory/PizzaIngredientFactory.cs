using System.Collections.Generic;
using ch04_factory.Ingredient;

namespace ch04_factory
{
    public interface PizzaIngredientFactory
    {
        Dough createDough();
        Sauce createSauce();
        Cheese createCheese();
        List<Veggies> createGeggies();
        Pepperoni createPepperoni();
        Clams createClams();
    }
}