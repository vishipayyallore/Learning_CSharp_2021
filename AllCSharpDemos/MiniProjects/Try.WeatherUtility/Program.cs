using WeatherUtility;

using static System.Console;

namespace Try.WeatherUtility
{

    class Program
    {
        static void Main(string[] args)
        {
            IWeatherUtilities weatherUtilities = new WeatherUtilities();

            var fahrenheit = 65;
            var celsius = weatherUtilities.FahrenheitToCelsius(fahrenheit);
            WriteLine($"{fahrenheit}°F equals {celsius}°C");

            WriteLine("\n\nPress any key ...");
            ReadKey();
        }

    }

}
