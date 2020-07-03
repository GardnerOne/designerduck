using designerduck.Models.Behaviors;

namespace designerduck.Models
{
    public class DuckCall
    {
        public IQuackBehavior QuackBehavior { get; set; }

        public DuckCall()
        {
            QuackBehavior = new Quack();   
        }

        public void performQuack()
        {
            QuackBehavior.quack();
        }
    }
}