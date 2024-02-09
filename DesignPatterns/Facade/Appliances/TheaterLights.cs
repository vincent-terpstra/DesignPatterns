using DesignPatterns.Facade.Interfaces;

namespace DesignPatterns.Facade.Appliances;

public class TheaterLights : ITheaterLights
{
    public void On()
    {
        Console.WriteLine("Theater lights are on");
    }

    public void Off()
    {
        Console.WriteLine("Theater lights are off");
    }

    public void Dim(int i)
    {
        Console.WriteLine($"Lights are dimmed to {i}");
    }

}