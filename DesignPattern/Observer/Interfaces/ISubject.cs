using System;
namespace WeatherApp
{
    public interface ISubject<T>
    {
        void Register(IObserver<T> observer);
        void Remove(IObserver<T> observer);
        void Notify();
    }
}
