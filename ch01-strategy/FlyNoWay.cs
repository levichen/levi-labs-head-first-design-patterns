namespace ch01_strategy
{
    public class FlyNoWay : IFlyBehavior
    {
        public void Fly()
        {
            System.Console.WriteLine("I can not fly");
        }
    }
}