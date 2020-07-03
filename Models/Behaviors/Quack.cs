namespace designerduck.Models.Behaviors
{
    public class Quack : IQuackBehavior
    {
        public void quack()
        {
            System.Console.WriteLine("Quack!");
        }
    }
}