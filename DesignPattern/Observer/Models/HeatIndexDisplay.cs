using System;

namespace WeatherApp
{
    public class HeatIndexDisplay : IObserver<WeatherChangeEvent>, IDisplayElement
    {
        float temperture;
        float humidity;
        float pressure;

        public void Display()
        {
            Console.WriteLine("heatindex");
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
