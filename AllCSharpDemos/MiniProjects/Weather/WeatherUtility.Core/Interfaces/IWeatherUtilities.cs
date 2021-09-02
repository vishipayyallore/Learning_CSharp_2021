namespace WeatherUtility.Core.Interfaces
{

    public interface IWeatherUtilities
    {
        float FahrenheitToCelsius(float temperatureInFahrenheit);

        float CelsiusToFahrenheit(float temperatureInCelsius);
    }

}
