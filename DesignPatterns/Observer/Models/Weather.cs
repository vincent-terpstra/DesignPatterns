using DesignPatterns.Observer.Pull.Interfaces;

namespace DesignPatterns.Observer.Push.Models;

public class WeatherData : IWeatherData
{
    public required float Temperature { get; init; }
    public required float Humidity { get; init; }
    public required float Pressure { get; init; }
}