
using ch03_decorator.Coffee;

namespace ch03_decorator.Condiments
{
    public abstract class CondimentDecorator : Beverage
    {
        public abstract override string getDescription();
    }
}