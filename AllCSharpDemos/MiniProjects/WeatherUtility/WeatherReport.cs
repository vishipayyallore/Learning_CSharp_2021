using System;
using static System.Console;

namespace WeatherUtility
{

    public class WeatherReport : IWeatherReport
    {
        readonly IWeatherUtilities _weatherUtilities = new WeatherUtilities();

        public WeatherReport(IWeatherUtilities weatherUtilities)
        {
            _weatherUtilities = weatherUtilities ?? throw new ArgumentNullException(nameof(weatherUtilities));
        }

        private static float ComfortIndex(float temperatureFahrenheit, float humidityPercent)
        {
            var comfortIndex = (temperatureFahrenheit + humidityPercent) / 4;

            return comfortIndex;
        }

        public void DisplayReport(string location, float temperatureCelsius, float humidity)
        {
            var temperatureFahrenheit = _weatherUtilities.CelsiusToFahrenheit(temperatureCelsius);

            WriteLine($"Comfort Index for {location} : {ComfortIndex(temperatureFahrenheit, humidity)}");
        }

    }

}
