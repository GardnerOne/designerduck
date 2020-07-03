namespace DesignerDuck.Models
{
    public class FlyNoWay : IFlyBehavior
    {
        public void fly()
        {
            System.Console.WriteLine("I can't fly.");
        }
    }
}