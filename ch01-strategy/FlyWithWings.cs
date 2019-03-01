namespace ch01_strategy
{
    public class FlyWithWings : IFlyBehavior
    {
        public void Fly()
        {
            System.Console.WriteLine("I'm flying!!");
        }
    }
}