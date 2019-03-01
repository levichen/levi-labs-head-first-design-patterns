namespace ch01_strategy
{
    public class Squeak : IQuackbeavior
    {
        public void Quack()
        {
            System.Console.WriteLine("Squeak");
        }
    }
}