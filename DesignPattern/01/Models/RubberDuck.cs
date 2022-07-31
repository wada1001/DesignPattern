using System;

namespace SimUDuck.Models
{
    public class RubberDuck : Duck
    {
        public RubberDuck()
        {
            flyBehaviour = new FlyNoWay();
            quackBehaviour = new NormalQuack(0);
        }

        public override void Display()
        {
            Console.WriteLine("(i am rubber duck)");
        }
    }
}
