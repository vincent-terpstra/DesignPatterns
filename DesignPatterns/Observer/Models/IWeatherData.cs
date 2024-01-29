namespace DesignPatterns.Observer.Pull.Interfaces;

public interface IWeatherData
{
    float Temperature { get; }
    float Humidity { get; }
    float Pressure { get; }
}