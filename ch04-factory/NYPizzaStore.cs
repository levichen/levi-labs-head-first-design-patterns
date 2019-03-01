namespace ch04_factory
{
    public class NYPizzaStore : PizzaStore
    {
        protected override Pizza createPizza(string type)
        {
            PizzaIngredientFactory ingredientFactory = new NYPizzaIngredientFactory();

            if (type.Equals("cheese"))
            {
                return new NYStyleCheesePizza(ingredientFactory);
            }

            return null;
        }
    }
}