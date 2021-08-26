namespace WeatherUtility
{
    public interface IWeatherReport
    {
        void DisplayReport(string location, float temperatureCelsius, float humidity);
    }
}