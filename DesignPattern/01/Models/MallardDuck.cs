using System;

namespace SimUDuck.Models
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            // not good...
            flyBehaviour = new FlyWithWing(3);
            quackBehaviour = new NormalQuack(4);
        }

        public override void Display()
        {
            Console.WriteLine("i am mallard duck");
        }
    }
}
