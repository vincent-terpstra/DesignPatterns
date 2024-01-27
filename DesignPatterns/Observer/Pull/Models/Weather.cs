namespace DesignPatterns.Observer.Pull.Models;

public class WeatherData
{
    public required float Temperature { get; init; }
    public required float Humidity { get; init; }
    public required float Pressure { get; init; }
}