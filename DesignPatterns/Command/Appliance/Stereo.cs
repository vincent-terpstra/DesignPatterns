using DesignPatterns.Command.Interfaces;

namespace DesignPatterns.Command.Appliance;

public class Stereo
{
    private readonly string _room;
    private bool _isOn;

    public Stereo(string room)
    {
        _room = room;
    }

    public void On()
    {
        _isOn = true;
        Console.WriteLine($"Stereo in {_room} turned on");
    }
    
    public void Off()
    {
        _isOn = false;
        Console.WriteLine($"Stereo in {_room} turned off");
    }
    
    public bool IsOn => _isOn;

    public CommandAction TurnOnCommand => new(On, Off);
    public CommandAction TurnOff => new(Off, On);
}