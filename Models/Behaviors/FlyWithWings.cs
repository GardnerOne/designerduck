namespace DesignerDuck.Models.Behaviors
{
    public class FlyWithWings : IFlyBehavior
    {
        public void fly()
        {
            System.Console.WriteLine("I'm flying!");
        }
    }
}