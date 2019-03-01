
namespace ch01_strategy
{
    public abstract class Duck
    {
        protected IFlyBehavior flyBehavior;
        protected IQuackbeavior quackBehavior;

        public Duck() { }

        public abstract void display();

        public void performFly()
        {
            flyBehavior.Fly();
        }
        public void performQuack()
        {
            quackBehavior.Quack();
        }

        public void setFlyBehavior(IFlyBehavior fb)
        {
            flyBehavior = fb;
        }

        public void setQuackBehavior(IQuackbeavior qb)
        {
            quackBehavior = qb;
        }

        public void swim()
        {
            System.Console.WriteLine("All ducks float, even decoys");
        }
    }
}