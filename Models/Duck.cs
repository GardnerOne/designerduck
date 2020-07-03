using designerduck.Models.Behaviors;

namespace designerduck.Models
{
    public abstract class Duck
    {
        public IFlyBehavior FlyBehavior { get; set; }
        public IQuackBehavior QuackBehavior { get; set; }

        public Duck()
        {
            
        }

        public abstract void display();

        public void performFly()
        {
            FlyBehavior.fly();
        }

        public void performQuack()
        {
            QuackBehavior.quack();
        }

        public void swim()
        {
            System.Console.WriteLine("All ducks float, even decoys!");
        }
    }
}