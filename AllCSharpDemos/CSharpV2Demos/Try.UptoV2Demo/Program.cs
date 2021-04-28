using Microsoft.Extensions.DependencyInjection;
using UptoV2Demo;
using Utilities.Generator;

using static System.Console;

namespace Try.UptoV2Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            // create service collection
            var services = ConfigureServices();

            // Generate a provider
            var serviceProvider = services.BuildServiceProvider();

            // IMPORTANT! Register our application entry point
            // Kick off our actual code
            // serviceProvider.GetService<NamesArrayApp>().Run();
            // serviceProvider.GetService<NamesArrayListApp>().Run();
            serviceProvider.GetService<NamesStringCollectionApp>().Run();


            WriteLine("\n\nPress any key ...");
            ReadKey();
        }

        private static IServiceCollection ConfigureServices()
        {
            IServiceCollection services = new ServiceCollection();

            services.AddTransient<INameGenerator, NameGenerator>();
            services.AddTransient<IPrintHelper, PrintHelper>();

            services.AddTransient<INamesArray, NamesArray>();
            services.AddTransient<INamesArrayList, NamesArrayList>();
            services.AddTransient<INamesStringCollection, NamesStringCollection>();

            // IMPORTANT! Register our application entry point
            services.AddTransient<NamesArrayApp>();
            services.AddTransient<NamesArrayListApp>();
            services.AddTransient<NamesStringCollectionApp>();

            return services;
        }
    }
}
