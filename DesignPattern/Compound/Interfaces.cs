using System;
namespace SimUDuck2
{
    public interface Quackable : QuackObservable
    {
        void Quack();
    }

    public interface QuackObservable
    {
        void RegisterObserver(Observer observer);
        void Notify();
    }

    public interface Observer
    {
        void Update(QuackObservable quackable);
    }

    public interface IQuackableFactory
    {
        Quackable CreateMallard();
        Quackable CreateReadHead();
        Quackable CreateCall();
        Quackable CreateRubber();
    }
}
