using DesignPatterns.Observer.Interfaces;

namespace DesignPatterns.Observer.DisplayElements;

public class CurrentConditionsDisplay: IDisplay, IObserver
{
    private readonly ISubject _subject;

    public CurrentConditionsDisplay(ISubject subject)
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

    public void Update(float temperature, float humidity, float pressure)
    {
        _temperature = temperature;
        _humidity = humidity;
        _pressure = pressure;
    }
}