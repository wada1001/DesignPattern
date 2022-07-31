using System;
using System.Collections.Generic;

namespace WeatherApp
{
    public class WeatherData : ISubject<WeatherChangeEvent>
    {
        List<IObserver<WeatherChangeEvent>> observers = new List<IObserver<WeatherChangeEvent>>();

        float temperture;
        float humidity;
        float pressure;

        public float GetTemperture()
        {
            return temperture;
        }

        public float GetHumidity()
        {
            return humidity;
        }

        public float GetPressure()
        {
            return pressure;
        }

        /// <summary>
        /// call when value changed.
        /// </summary>
        public void MeasurementsChanged(float temperture, float humidity, float pressure)
        {
            this.temperture = temperture;
            this.humidity = humidity;
            this.pressure = pressure;
            this.Notify();
        }

        public void Register(IObserver<WeatherChangeEvent> observer)
        {
            observers.Add(observer);
        }

        public void Remove(IObserver<WeatherChangeEvent> observer)
        {
            observers.Remove(observer);
        }

        public void Notify()
        {
            observers.ForEach(o => o.Update(new WeatherChangeEvent()
            {
                temp     = GetTemperture(),
                humidity = GetHumidity(),
                pressure = GetPressure()
            }));
        }
    }
}
