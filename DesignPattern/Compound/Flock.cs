using System;
using System.Collections.Generic;

namespace SimUDuck2
{
    public class Flock : Quackable
    {
        List<Quackable> quackables = new List<Quackable>();

        public Flock(List<Quackable> quackables) => this.quackables = quackables;

        public void Add(Quackable quackable) => quackables.Add(quackable);
        public void Notify() => quackables.ForEach(x => x.Notify());
        public void Quack() => quackables.ForEach(x => x.Quack());
        public void RegisterObserver(Observer observer)
        {
            quackables.ForEach(x => x.RegisterObserver(observer));
            quackables.ForEach(x => Console.WriteLine(x.ToString()));
        }
    }

    public class Observable : QuackObservable
    {
        List<Observer> observers = new List<Observer>();
        QuackObservable duck;

        public Observable(QuackObservable duck) => this.duck = duck;

        public void Notify() => observers.ForEach(x => x.Update(duck));
        public void RegisterObserver(Observer observer) => observers.Add(observer);
    }

    public class Quackologist : Observer
    {
        public void Update(QuackObservable quackable) => Console.WriteLine("record quack = " + quackable.ToString());
    }
}
