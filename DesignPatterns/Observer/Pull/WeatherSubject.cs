using DesignPatterns.Observer.Pull.Interfaces;

namespace DesignPatterns.Observer.Pull;

public class WeatherSubject : ISubject, IWeatherData
{
    private readonly IWeatherData _weatherData;
    private readonly List<IObserver> _subscribers = new();
    
    private float _temp;
    private float _humidity;
    private float _pressure;

    public WeatherSubject(IWeatherData weatherData)
    {
        _weatherData = weatherData;
    }

    public void MeasurementsChanged() => NotifyObservers();

    public void Register(IObserver observer)
    {
        if (!_subscribers.Contains(observer))
        {
            _subscribers.Add(observer);
        }
    }

    public void Remove(IObserver observer)
    {
        _subscribers.Remove(observer);
    }

    public void NotifyObservers()
    {
        _temp = _weatherData.GetTemperature();
        _humidity = _weatherData.GetHumidity();
        _pressure = _weatherData.GetPressure();

        foreach (var subscriber in _subscribers)
        {
            subscriber.Update();
        }
    }

    public float GetTemperature() => _temp;

    public float GetHumidity() => _humidity;

    public float GetPressure() => _pressure;
}