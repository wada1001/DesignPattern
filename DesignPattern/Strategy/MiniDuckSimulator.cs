using System;
using System.Collections.Generic;
using SimUDuck.Models;

namespace SimUDuck
{
    public static class MiniDuckSimulator
    {
        public static void Perform()
        {
            List<Duck> ducks = new List<Duck>();

            ducks.Add(new MallardDuck());
            ducks.Add(new RubberDuck());

            ducks.ForEach(d => {
                d.Display();

                d.Swim();
                d.PerformFly();
                d.PerformQuack();
            });
        }
    }
}
