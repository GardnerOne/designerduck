using designerduck.Models.Behaviors;

namespace designerduck.Models
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            flyBehavior = new FlyWithWings();
            quackBehavior = new Quack();
        }

        public override void display()
        {
            System.Console.WriteLine("I'm a real Mallard duck.");
        }
    }
}