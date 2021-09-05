using HeaderFooter.Interfaces.Utilities;
using System;
using System.Collections.Generic;
using WeatherUtility.Core.Entities;
using WeatherUtility.Core.Interfaces;

using static System.Console;

namespace Try.WeatherUtility
{

    public class WeatherUtilityApp
    {
        private readonly IWeatherUtilities _weatherUtilities;
        private readonly IWeatherReport _weatherReport;
        private readonly IHeader _header;
        private readonly IFooter _footer;

        // Prefilling with Dummy data
        private IList<WeatherData> WeatherDatas { get; set; } = GetWeatherData();

        // TODO: Need two methods. One for Weather Conversion and One for Weather Report.

        public WeatherUtilityApp(IWeatherUtilities weatherUtilities, IWeatherReport weatherReport,
            IHeader header, IFooter footer)
        {
            _weatherUtilities = weatherUtilities ?? throw new ArgumentNullException(nameof(weatherUtilities));

            _weatherReport = weatherReport ?? throw new ArgumentNullException(nameof(weatherReport));

            _header = header ?? throw new ArgumentNullException(nameof(header));

            _footer = footer ?? throw new ArgumentNullException(nameof(footer));
        }

        // Application starting point
        public void Run()
        {
            ShowWeatherConversion();

            ShowWeatherReport();
        }

        private void ShowWeatherConversion()
        {
            float fahrenheit = 65;

            _header.DisplayHeader('*', "Weather Conversions");

            var celsius = _weatherUtilities.FahrenheitToCelsius(fahrenheit);
            WriteLine($"{fahrenheit}°F equals {celsius}°C");

            fahrenheit = _weatherUtilities.CelsiusToFahrenheit(celsius);
            WriteLine($"{celsius}°C equals {fahrenheit}°F");

            _footer.DisplayFooter('-');
        }

        private void ShowWeatherReport()
        {
            _header.DisplayHeader('=', "Weather Report");

            foreach (var weatherData in WeatherDatas)
            {
                _weatherReport.DisplayReport(weatherData);
            }

            _footer.DisplayFooter('-');
        }

        // TODO: Get this data from SQLite
        private static IList<WeatherData> GetWeatherData() => new List<WeatherData>
            {
                new WeatherData { Location="San Francisco", TemperatureCelsius = 19, Humidity = 73 },
                new WeatherData { Location = "Denver", TemperatureCelsius = 21, Humidity = 55},
                new WeatherData { Location = "Bologna", TemperatureCelsius = 23, Humidity= 65 },
                new WeatherData { Location = "Hyderabad", TemperatureCelsius = 35, Humidity= 65 }
            };

    }

}
