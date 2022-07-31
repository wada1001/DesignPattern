using System;

namespace WeatherApp
{
    public class CurrentConditonDisplay : IObserver<WeatherChangeEvent>, IDisplayElement
    {
        float temperture;
        float humidity;
        float pressure;

        public void Display()
        {
            Console.WriteLine("current condition ... "
                + "temperture = " + temperture.ToString()
                + "humidity = " + humidity.ToString()
                + "pressure = " + pressure.ToString()
            );
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
