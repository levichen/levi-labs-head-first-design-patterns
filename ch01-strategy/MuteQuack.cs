namespace ch01_strategy
{
    public class MuteQuack : IQuackbeavior
    {
        public void Quack()
        {
            System.Console.WriteLine("<< Silence >>");
        }
    }
}