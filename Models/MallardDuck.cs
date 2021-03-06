using designerduck.Models.Behaviors;

namespace designerduck.Models
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            FlyBehavior = new FlyWithWings();
            QuackBehavior = new Quack();
        }

        public override void display()
        {
            System.Console.WriteLine("I'm a real Mallard duck.");
        }
    }
}