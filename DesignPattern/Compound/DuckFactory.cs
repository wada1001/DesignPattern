using System;
namespace SimUDuck2
{
    public class DuckFactory : IQuackableFactory
    {
        public Quackable CreateCall() => new DuckCall();
        public Quackable CreateMallard() => new MallardDuck();
        public Quackable CreateReadHead() => new RedHeadDuck();
        public Quackable CreateRubber() => new RubberDuck();
    }

    public class CountingDuckFactory : IQuackableFactory
    {
        public Quackable CreateCall() => new QuackCounter(new DuckCall());
        public Quackable CreateMallard() => new QuackCounter(new MallardDuck());
        public Quackable CreateReadHead() => new QuackCounter(new RedHeadDuck());
        public Quackable CreateRubber() => new QuackCounter(new RubberDuck());
    }
}
