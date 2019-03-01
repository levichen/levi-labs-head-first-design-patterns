namespace ch04_factory
{
    public class NYStyleCheesePizza : Pizza
    {
        private readonly PizzaIngredientFactory _ingredientFactory;
        public NYStyleCheesePizza(PizzaIngredientFactory ingredientFactory)
        {
            this._ingredientFactory = ingredientFactory;

            this.name = "NY style Sauce and Cheese Pizza";
        }

        public override void prepare()
        {
            this.dough = this._ingredientFactory.createDough();
            this.sauce = this._ingredientFactory.createSauce();
            this.cheese = this._ingredientFactory.createCheese();
        }
    }
}