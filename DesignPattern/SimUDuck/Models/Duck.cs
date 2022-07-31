using System;

namespace SimUDuck.Models
{
    /// <summary>
    /// Super Class
    /// </summary>
    public abstract class Duck
    {
        // delegate
        protected FlyBehaviour flyBehaviour;
        protected QuackBehaviour quackBehaviour;

        public void PerformFly() => flyBehaviour.Fly();

        public void PerformQuack() => quackBehaviour.Quack();

        public virtual void Swim() { Console.WriteLine("floating ..."); }

        public abstract void Display();
    }
}
