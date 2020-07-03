using System;
using designerduck.Models;
using designerduck.Models.Behaviors;

namespace designerduck
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck mallard = new MallardDuck();
            mallard.performFly();
            mallard.performQuack();

            Duck model = new ModelDuck();
            model.performFly();
            // Dynamically update a class at runtime
            model.FlyBehavior = new FlyRocketPowered();       
            model.performFly();

            DuckCall duckCall = new DuckCall();
            duckCall.performQuack();
        }
    }
}
