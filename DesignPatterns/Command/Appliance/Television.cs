using DesignPatterns.Command.Interfaces;

namespace DesignPatterns.Command.Appliance;

public class Television
{
    private readonly string _room;
    private bool _isOn;

    public Television(string room)
    {
        _room = room;
    }

    public void On()
    {
        _isOn = true;
        Console.WriteLine($"TV in {_room} turned on");
    }
    
    public void Off()
    {
        _isOn = false;
        Console.WriteLine($"TV in {_room} turned off");
    }
    
    public bool IsOn => _isOn;

    public CommandAction TurnOnCommand => new(On, Off);
    public CommandAction TurnOff => new(Off, On);
}