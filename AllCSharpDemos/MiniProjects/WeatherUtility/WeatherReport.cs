using System;

using static System.Console;

namespace WeatherUtility
{

    public class WeatherReport : IWeatherReport
    {
        private readonly IWeatherUtilities _weatherUtilities;

        public WeatherReport(IWeatherUtilities weatherUtilities)
        {
            _weatherUtilities = weatherUtilities ?? throw new ArgumentNullException(nameof(weatherUtilities));
        }

        private static float ComfortIndex(float temperatureFahrenheit, float humidityPercent)
        {
            var comfortIndex = (temperatureFahrenheit + humidityPercent) / 4;

            return comfortIndex;
        }

        public void DisplayReport(WeatherData weatherData)
        {
            var temperatureFahrenheit = _weatherUtilities.CelsiusToFahrenheit(weatherData.TemperatureCelsius);

            WriteLine($"Comfort Index for {weatherData.Location} : {ComfortIndex(temperatureFahrenheit, weatherData.Humidity)}");
        }

    }

}
