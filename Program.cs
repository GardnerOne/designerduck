using System;
using designerduck.Models;

namespace designerduck
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck mallard = new MallardDuck();
            mallard.performFly();
            mallard.performQuack();
            
        }
    }
}
