namespace ch02_observer
{
    public class CurrentCoditionsDisplay : IObserver, IDisplayElement
    {
        private float _temperature;
        private float _humidity;
        private ISubject _weatherData;

        public CurrentCoditionsDisplay(ISubject weatherData)
        {
            this._weatherData = weatherData;

            this._weatherData.RegisterObserver(this);
        }

        public void Display()
        {
            System.Console.WriteLine($"Current conditions: {_temperature}F degrees and {_humidity}% humidity");
        }

        public void Update(float temp, float humidity, float pressure)
        {
            this._temperature = temp;
            this._humidity = humidity;

            Display();
        }
    }
}