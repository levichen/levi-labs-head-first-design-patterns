namespace ch01_strategy
{
    public class FlyRocketPowered : IFlyBehavior
    {
        public void Fly()
        {
            System.Console.WriteLine("I am flying with a rocket!!");
        }
    }
}