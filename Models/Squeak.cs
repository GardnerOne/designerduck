namespace DesignerDuck.Models
{
    public class Squeak : IQuackBehavior
    {
        public void quack()
        {
            System.Console.WriteLine("Squeak.");
        }
    }
}