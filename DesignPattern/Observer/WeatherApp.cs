using System;
using System.Collections.Generic;

namespace WeatherApp
{
    public static class WeatherApp
    {
        public static void Perform()
        {
            WeatherData subject = new WeatherData();

            subject.Register(new CurrentConditonDisplay());
            subject.Register(new StaticsDisplay());
            subject.Register(new ForecastDisplay());

            subject.MeasurementsChanged(20, 40, 30.4f);
            subject.MeasurementsChanged(22, 43, 30.1f);
            subject.MeasurementsChanged(21, 22, 30.2f);
        }
    }
}
