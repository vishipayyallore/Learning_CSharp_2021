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

        // Prefilling with Dummy data
        private IList<WeatherData> WeatherDatas { get; set; } = GetWeatherData();

        public WeatherUtilityApp(IWeatherUtilities weatherUtilities, IWeatherReport weatherReport)
        {
            _weatherUtilities = weatherUtilities ?? throw new ArgumentNullException(nameof(weatherUtilities));

            _weatherReport = weatherReport ?? throw new ArgumentNullException(nameof(weatherReport));
        }

        // Application starting point
        public void Run()
        {
            ShowWeatherConversion();

            ShowWeatherReport();
        }

        private static void DisplayHeader(char header, string title, int length = 100)
        {
            var leftPadValue = ((length - title.Length) / 2) + title.Length;
            string headerValue = new(header, length);

            WriteLine($"\n\n{headerValue}");
            WriteLine(title.PadLeft(leftPadValue));
            WriteLine($"{headerValue}\n");
        }

        private static void DisplayFooter(char footer, int length = 100)
        {
            WriteLine($"\n{new string(footer, length)}\n");
        }

        private void ShowWeatherReport()
        {
            DisplayHeader('=', "Weather Report");

            foreach (var weatherData in WeatherDatas)
            {
                _weatherReport.DisplayReport(weatherData);
            }

            DisplayFooter('-');
        }

        private void ShowWeatherConversion()
        {
            float fahrenheit = 65;

            DisplayHeader('*', "Weather Conversions");

            var celsius = _weatherUtilities.FahrenheitToCelsius(fahrenheit);
            WriteLine($"{fahrenheit}°F equals {celsius}°C");

            fahrenheit = _weatherUtilities.CelsiusToFahrenheit(celsius);
            WriteLine($"{celsius}°C equals {fahrenheit}°F");

            DisplayFooter('-');
        }

        private static IList<WeatherData> GetWeatherData()
        {
            return new List<WeatherData>
            {
                new WeatherData { Location="San Francisco", TemperatureCelsius = 19, Humidity = 73 },
                new WeatherData { Location = "Denver", TemperatureCelsius = 21, Humidity = 55},
                new WeatherData { Location = "Bologna", TemperatureCelsius = 23, Humidity= 65 },
                new WeatherData { Location = "Hyderabad", TemperatureCelsius = 35, Humidity= 65 }
            };
        }

    }

}
