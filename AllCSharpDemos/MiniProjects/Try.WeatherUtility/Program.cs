using Microsoft.Extensions.DependencyInjection;
using WeatherUtility;

using static System.Console;

namespace Try.WeatherUtility
{

    class Program
    {
        static void Main(string[] args)
        {
            //IWeatherUtilities weatherUtilities = new WeatherUtilities();

            //var fahrenheit = 65;
            //var celsius = weatherUtilities.FahrenheitToCelsius(fahrenheit);
            //WriteLine($"{fahrenheit}°F equals {celsius}°C");

            // create service collection
            var services = ConfigureServices();

            // Generate a provider
            var serviceProvider = services.BuildServiceProvider();

            // Kick off our actual code
            serviceProvider.GetService<WeatherUtilityApp>().Run();

            WriteLine("\n\nPress any key ...");
            ReadKey();
        }

        private static IServiceCollection ConfigureServices()
        {
            IServiceCollection services = new ServiceCollection();

            services.AddTransient<IWeatherUtilities, WeatherUtilities>();
            services.AddTransient<IWeatherReport, WeatherReport>();

            // IMPORTANT! Register our application entry point
            services.AddTransient<WeatherUtilityApp>();

            return services;
        }
    }

}
