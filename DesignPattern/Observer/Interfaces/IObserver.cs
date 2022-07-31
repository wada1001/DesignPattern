using System;
namespace WeatherApp
{
    public interface IObserver<T>
    {
        void Update(T value);
    }
}
