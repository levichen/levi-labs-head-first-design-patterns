namespace ch02_observer_in_c_sharp
{
    public class WeatherData
    {
        private float _temperature;
        private float _humidity;
        private float _pressure;

        public WeatherData(float temperature, float humidity, float pressure)
        {
            this._temperature = temperature;
            this._humidity = humidity;
            this._pressure = pressure;
        }

        public float Temperature
        {
            get { return this._temperature; }
        }

        public float Humidity
        {
            get { return this._humidity; }
        }

        public float Pressure
        {
            get { return this._pressure; }
        }

    }
}