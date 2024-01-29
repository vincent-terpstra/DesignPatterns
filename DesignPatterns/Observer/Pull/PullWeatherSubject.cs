using DesignPatterns.Observer.Models;
using DesignPatterns.Observer.Pull.Interfaces;

namespace DesignPatterns.Observer.Pull;

public class PullWeatherSubject : ISubject, IWeatherData
{
    private readonly IWeatherData _weatherData;
    private readonly List<IObserver> _subscribers = new();
    
    private float _temp;
    private float _humidity;
    private float _pressure;

    public PullWeatherSubject(IWeatherData weatherData)
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
        _temp = _weatherData.Temperature;
        _humidity = _weatherData.Humidity;
        _pressure = _weatherData.Pressure;

        foreach (var subscriber in _subscribers)
        {
            subscriber.Update();
        }
    }

    public float Temperature => _temp;

    public float Humidity => _humidity;

    public float Pressure => _pressure;
}