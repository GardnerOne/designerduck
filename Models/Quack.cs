namespace DesignerDuck.Models
{
    public class Quack : IQuackBehavior
    {
        public void quack()
        {
            System.Console.WriteLine("Quack!");
        }
    }
}