using Microsoft.Extensions.DependencyInjection;
using Utilities.Generator;

using static System.Console;

namespace Try.Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            // create service collection
            var services = ConfigureServices();

            // Generate a provider
            var serviceProvider = services.BuildServiceProvider();

            // Kick off our actual code
            serviceProvider.GetService<TryGeneratorApplication>().Run();

            WriteLine("\n\nPress any key ...");
            ReadKey();
        }

        private static IServiceCollection ConfigureServices()
        {
            IServiceCollection services = new ServiceCollection();

            services.AddTransient<INameGenerator, NameGenerator>();

            // IMPORTANT! Register our application entry point
            services.AddTransient<TryGeneratorApplication>();

            return services;
        }

    }

}
