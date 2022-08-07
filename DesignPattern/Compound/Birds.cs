using System;
namespace SimUDuck2
{
    public class MallardDuck : Quackable
    {
        Observable observable;
        public MallardDuck()
        {
            this.observable = new Observable(this);
        }

        public void Notify() => observable.Notify();
        public void RegisterObserver(Observer observer) => observable.RegisterObserver(observer);
        public void Quack()
        {
            Console.WriteLine("quack");
            Notify();
        }
    }

    public class RedHeadDuck : Quackable
    {
        Observable observable;
        public RedHeadDuck()
        {
            this.observable = new Observable(this);
        }

        public void Notify() => observable.Notify();
        public void RegisterObserver(Observer observer) => observable.RegisterObserver(observer);
        public void Quack()
        {
            Console.WriteLine("quack");
            Notify();
        }
    }

    public class DuckCall : Quackable
    {
        Observable observable;
        public DuckCall()
        {
            this.observable = new Observable(this);
        }

        public void Notify() => observable.Notify();
        public void RegisterObserver(Observer observer) => observable.RegisterObserver(observer);
        public void Quack()
        {
            Console.WriteLine("quack quack");
            Notify();
        }
    }

    public class RubberDuck : Quackable
    {
        Observable observable;
        public RubberDuck()
        {
            this.observable = new Observable(this);
        }

        public void Notify() => observable.Notify();
        public void RegisterObserver(Observer observer) => observable.RegisterObserver(observer);
        public void Quack()
        {
            Console.WriteLine("squawk");
            Notify();
        }
    }

    public class Goose
    {
        public void Honk() => Console.WriteLine("gabble");
    }

    // Adapter
    public class DuckAdapter : Quackable
    {
        Goose goose;
        Observable observable;

        public DuckAdapter(Goose goose)
        {
            this.goose = goose;
            this.observable = new Observable(this);
            this.observable = new Observable(this);
        }

        public void Notify() => observable.Notify();
        public void RegisterObserver(Observer observer) => observable.RegisterObserver(observer);
        public void Quack()
        {
            goose.Honk();
            Notify();
        }
    }

    // Decorator
    public class QuackCounter : Quackable
    {
        Quackable duck;
        static int count;

        public QuackCounter(Quackable duck)
        {
            this.duck = duck;
        }

        public void Notify() => duck.Notify();
        public void RegisterObserver(Observer observer) => duck.RegisterObserver(observer);

        public void Quack()
        {
            duck.Quack();
            count++;
        }

        public static int GetTotalQuack() => count;
    }
}
