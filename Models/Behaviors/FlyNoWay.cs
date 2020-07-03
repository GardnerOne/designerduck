namespace DesignerDuck.Models.Behaviors
{
    public class FlyNoWay : IFlyBehavior
    {
        public void fly()
        {
            System.Console.WriteLine("I can't fly.");
        }
    }
}