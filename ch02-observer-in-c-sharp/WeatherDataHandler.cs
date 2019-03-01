using System;

namespace ch02_observer_in_c_sharp
{
    public class WeatherDataHandler : IObservable<WeatherData>
    {
        public IDisposable Subscribe(IObserver<WeatherData> observer)
        {
            throw new NotImplementedException();
        }
    }
}