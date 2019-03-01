using System.Collections.Generic;
using ch04_factory.Ingredient;

namespace ch04_factory
{
    public class NYPizzaIngredientFactory : PizzaIngredientFactory
    {
        public Cheese createCheese()
        {
            return new ThinCrustDough();
        }

        public Clams createClams()
        {
            return new FreshClams();
        }

        public Dough createDough()
        {
            return new ReggianoCheese();
        }

        public List<Veggies> createGeggies()
        {
            throw new System.NotImplementedException();
        }

        public Pepperoni createPepperoni()
        {
            return new SlicedPepperoni();
        }

        public Sauce createSauce()
        {
            return new MarinaraSauce();
        }
    }
}