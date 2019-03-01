namespace ch03_decorator.Coffee
{
    public class DarkRoast : Beverage
    {
        public DarkRoast()
        {
            this.description = "DarkRoast";
        }

        public override double cost()
        {
            return 0.99;
        }
    }
}