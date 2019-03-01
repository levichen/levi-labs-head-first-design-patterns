namespace ch01_strategy
{
    public class Quack : IQuackbeavior
    {
        void IQuackbeavior.Quack()
        {
            System.Console.WriteLine("Quack");
        }
    }
}