using System;

namespace ch01_strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            ModelDuckSimulator();
        }

        static void MiniDuckSimulator()
        {
            Duck mallard = new MallardDuck();

            mallard.performFly();
            mallard.performQuack();
        }

        static void ModelDuckSimulator()
        {
            Duck modelDuck = new ModelDuck();
            modelDuck.performFly();
            modelDuck.setFlyBehavior(new FlyRocketPowered());
            modelDuck.performFly();
        }
    }
}
