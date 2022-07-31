using System;

namespace WeatherApp
{
    public class StaticsDisplay : IObserver<WeatherChangeEvent>, IDisplayElement
    {
        float temperture;
        float humidity;
        float pressure;

        public void Display()
        {
            Console.WriteLine("statics");
        }

        public void Update(WeatherChangeEvent value)
        {
            this.temperture = value.temp;
            this.humidity = value.humidity;
            this.pressure = value.pressure;
            Display();
        }
    }
}
