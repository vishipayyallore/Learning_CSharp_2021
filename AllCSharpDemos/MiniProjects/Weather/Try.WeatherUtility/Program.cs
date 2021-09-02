using HeaderFooter.Interfaces.Utilities;
using HeaderFooter.Utilities;
using Microsoft.Extensions.DependencyInjection;
using WeatherUtility;
using WeatherUtility.Core.Interfaces;

using static System.Console;

namespace Try.WeatherUtility
{

    class Program
    {
        static void Main(string[] args)
        {
            // create service collection
            var services = ConfigureServices();

            // Generate a provider
            var serviceProvider = services.BuildServiceProvider();

            // Kick off the actual code
            serviceProvider.GetService<WeatherUtilityApp>().Run();

            WriteLine("\n\nPress any key ...");
            ReadKey();
        }

        private static IServiceCollection ConfigureServices()
        {
            IServiceCollection services = new ServiceCollection();

            services.AddTransient<IWeatherUtilities, WeatherUtilities>();
            services.AddTransient<IWeatherReport, WeatherReport>();

            // Header Footer
            services.AddTransient<IHeader, Header>();
            services.AddTransient<IFooter, Footer>();

            // IMPORTANT! Register the application entry point
            services.AddTransient<WeatherUtilityApp>();

            return services;
        }
    }

}
