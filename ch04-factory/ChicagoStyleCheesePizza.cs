namespace ch04_factory
{
    public class ChicagoStyleCheesePizza : Pizza
    {
        public ChicagoStyleCheesePizza()
        {
            this.name = "Chicao Style Deep Dish Cheese Pizza";
        }

        public new void cut()
        {
            System.Console.WriteLine("Cutting the pizza into square slices");
        }

        public override void prepare()
        {
            throw new System.NotImplementedException();
        }
    }
}