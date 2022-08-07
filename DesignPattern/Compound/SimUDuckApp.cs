using System;
using System.Collections.Generic;

namespace SimUDuck2
{
    public static class SimUDuckApp
    {
        public static void Perform()
        {
            var factory = new CountingDuckFactory();
            var d1 = factory.CreateCall();
            var d2 = factory.CreateMallard();
            var d3 = factory.CreateReadHead();
            var d4 = factory.CreateRubber();

            var flock = new Flock(new List<Quackable>() { d1, d2, d3, d4 });

            var quackologist = new Quackologist();
            flock.RegisterObserver(quackologist);

            Simulate(flock);

            Console.WriteLine("total quack = " + QuackCounter.GetTotalQuack().ToString());
        }

        static void Simulate(Quackable quackable) => quackable.Quack();
    }

    
}
