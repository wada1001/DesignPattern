using System;

namespace SimUDuck.Models
{
    public class FlyNoWay : FlyBehaviour
    {
        public void Fly()
        {
            Console.WriteLine("i cannot fly...");
        }
    }
}
