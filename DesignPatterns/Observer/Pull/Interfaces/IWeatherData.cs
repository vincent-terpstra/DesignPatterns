namespace DesignPatterns.Observer.Pull.Interfaces;

public interface IWeatherData
{
    float GetTemperature();
    float GetHumidity();
    float GetPressure();
}