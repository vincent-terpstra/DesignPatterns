using DesignPatterns.Observer.Interfaces;

namespace DesignPatterns.Observer;

public class WeatherData : ISubject
{
    private readonly IWeatherService _weatherService;
    private readonly List<IObserver> _subscribers = new();

    public WeatherData(IWeatherService weatherService)
    {
        _weatherService = weatherService;
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
        float temp = _weatherService.GetTemperature();
        float humidity = _weatherService.GetHumidity();
        float pressure = _weatherService.GetPressure();

        foreach (var subscriber in _subscribers)
        {
            subscriber.Update(temp, humidity, pressure);
        }
    }
}