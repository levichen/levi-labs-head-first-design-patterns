using System;

namespace ch02_observer
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherStation();
        }

        static void WeatherStation()
        {
            WeatherData weatherData = new WeatherData();

            CurrentCoditionsDisplay currentDisplay = new CurrentCoditionsDisplay(weatherData);
            HeatIndexDisplay heartIndexDisplay = new HeatIndexDisplay(weatherData);

            weatherData.SetMeasurements(80, 65, 30.4f);
            weatherData.SetMeasurements(82, 70, 29.2f);
            weatherData.SetMeasurements(78, 90, 29.2f);
        }
    }
}
