using designerduck.Models.Behaviors;

namespace designerduck.Models
{
    public class ModelDuck : Duck
    {
        public ModelDuck()
        {
            FlyBehavior = new FlyNoWay();
            QuackBehavior = new Quack();
        }

        public override void display()
        {
            System.Console.WriteLine("I'm a model duck.");
        }
    }
}