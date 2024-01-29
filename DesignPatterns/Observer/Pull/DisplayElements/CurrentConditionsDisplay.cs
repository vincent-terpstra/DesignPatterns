using DesignPatterns.Observer.Pull.Interfaces;

namespace DesignPatterns.Observer.Pull.DisplayElements;

public class CurrentConditionsDisplay: IDisplay, IObserver
{
    private readonly WeatherSubject _subject;

    public CurrentConditionsDisplay(WeatherSubject subject)
    {
        _subject = subject;
        _subject.Register(this);
    }
    
    private float _temperature;
    private float _humidity;
    private float _pressure;

    public void Display()
    {
        Console.WriteLine($"Current conditions: {_temperature} F degrees and {_humidity} % humidity");
    }

    public void Update()
    {
        _temperature = _subject.Temperature;
        _humidity = _subject.Humidity;
        _pressure = _subject.Pressure;
    }
}