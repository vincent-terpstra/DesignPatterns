﻿using DesignPatterns.Command.Interfaces;

namespace DesignPatterns.Command.Appliance;

public class Light
{
    private bool _isOn;
    
    public void On()
    {
        _isOn = true;
        Console.WriteLine("Turning light off");
    }
    
    public void Off()
    {
        _isOn = false;
        Console.WriteLine("Turning light off");
    }

    public bool IsOn => _isOn;

    public CommandAction LightOnCommand => new(On, Off);
    public CommandAction LightOffCommand => new(Off, On);
}