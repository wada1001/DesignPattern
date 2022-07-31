using System;

namespace SimUDuck.Models
{
    public class FlyWithWing : FlyBehaviour
    {
        int wingCount;

        public FlyWithWing(int wingCount = 2)
        {
            this.wingCount = wingCount;
        }

        public void Fly()
        {
            Console.WriteLine("I have " + wingCount.ToString() + " wings");
            Console.WriteLine("flying in the sky !!");
        }
    }
}
