namespace DesignerDuck.Models.Behaviors
{
    public class Squeak : IQuackBehavior
    {
        public void quack()
        {
            System.Console.WriteLine("Squeak.");
        }
    }
}