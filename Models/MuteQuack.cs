namespace DesignerDuck.Models
{
    public class MuteQuack : IQuackBehavior
    {
        public void quack()
        {
            System.Console.WriteLine("s i l e n c e");
        }
    }
}