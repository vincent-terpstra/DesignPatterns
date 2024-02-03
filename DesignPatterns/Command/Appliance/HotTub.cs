using DesignPatterns.Command.Interfaces;

namespace DesignPatterns.Command.Appliance;

public class HotTub
{
    private bool _isOn;

    public void On()
    {
        _isOn = true;
        Console.WriteLine($"Hot tub turned on");
    }

    public void Off()
    {
        _isOn = false;
        Console.WriteLine($"Hot tub turned off");
    }

    public bool IsOn => _isOn;

    public CommandAction TurnOnCommand => new(On, Off);
    public CommandAction TurnOff => new(Off, On);
}