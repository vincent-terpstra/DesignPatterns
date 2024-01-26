namespace DesignPatterns.Observer;

public interface IWeatherService
{
    float GetTemperature();
    float GetHumidity();
    float GetPressure();
}