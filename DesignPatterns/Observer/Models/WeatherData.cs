namespace DesignPatterns.Observer.Models;

public class WeatherData : IWeatherData
{
    public required float Temperature { get; init; }
    public required float Humidity { get; init; }
    public required float Pressure { get; init; }
}