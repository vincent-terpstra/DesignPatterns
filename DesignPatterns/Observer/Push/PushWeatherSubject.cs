using DesignPatterns.Observer.Pull.Interfaces;
using DesignPatterns.Observer.Push.Interfaces;
using DesignPatterns.Observer.Push.Models;

namespace DesignPatterns.Observer.Push;

public class PushWeatherSubject : IPushSubject<WeatherData>
{
    private readonly IWeatherData _weatherData;

    public PushWeatherSubject(IWeatherData weatherData)
    {
        _weatherData = weatherData;
    }
    
    private Action<WeatherData>? _onUpdate;

    public void Subscribe(IPushObserver<WeatherData> observer)
    {
        _onUpdate += observer.Update;
    }

    public void UnSubscribe(IPushObserver<WeatherData> observer)
    {
        _onUpdate -= observer.Update;
    }

    public void NotifyObservers()
    {
        WeatherData data = new WeatherData()
        {
            Temperature = _weatherData.GetTemperature(),
            Humidity = _weatherData.GetHumidity(),
            Pressure = _weatherData.GetPressure()
        };
        
        _onUpdate?.Invoke(data);
    }
}