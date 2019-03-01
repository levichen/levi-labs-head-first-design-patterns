using ch03_decorator.Coffee;

namespace ch03_decorator.Condiments
{
    public class Whip : CondimentDecorator
    {
        Beverage beverage;

        public Whip(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override double cost()
        {
            return 0.1 + beverage.cost();
        }

        public override string getDescription()
        {
            return beverage.getDescription() + ", Whip";
        }
    }
}