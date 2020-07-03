namespace designerduck.Models.Behaviors
{
    public class FlyRocketPowered : IFlyBehavior
    {
        public void fly()
        {
            System.Console.WriteLine("I'm flying with a rocket!");
        }
    }
}