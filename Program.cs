using System;
using DesignerDuck.Models;

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
