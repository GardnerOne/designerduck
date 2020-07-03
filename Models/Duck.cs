using designerduck.Models.Behaviors;

namespace designerduck.Models
{
    public abstract class Duck
    {
        public IFlyBehavior flyBehavior;
        public IQuackBehavior quackBehavior;

        public Duck()
        {
            
        }

        public abstract void display();

        public void performFly()
        {
            flyBehavior.fly();
        }

        public void performQuack()
        {
            quackBehavior.quack();
        }

        public void swim()
        {
            System.Console.WriteLine("All ducks float, even decoys!");
        }
    }
}