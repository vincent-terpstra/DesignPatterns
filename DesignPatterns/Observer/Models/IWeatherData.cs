namespace DesignPatterns.Observer.Models;

public interface IWeatherData
{
    float Temperature { get; }
    float Humidity { get; }
    float Pressure { get; }
}