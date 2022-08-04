using System;
namespace TurkeyAdapter
{
    public class MallardDuck : Duck
    {
        public void Fly() => Console.WriteLine("quack");
        public void Quack() => Console.WriteLine("flying");
    }

    public class WildTurkey : Turkey
    {
        public void Fly() => Console.WriteLine("flying short distance");
        public void Gobble() => Console.WriteLine("goblle");
    }

    public class TurkeyAdapter : Duck
    {
        Turkey turkey;

        public TurkeyAdapter(Turkey turkey) => this.turkey = turkey;

        public void Fly()
        {
            // turkey cannot fly long distance.
            for (int i = 0; i < 5; i++) turkey.Fly();
        }

        public void Quack() => turkey.Gobble();
    }

    public class DuckAdapter : Turkey
    {
        Duck duck;

        public DuckAdapter(Duck duck) => this.duck = duck;
        public void Fly() => duck.Fly();
        public void Gobble() => duck.Quack();
    }

}
