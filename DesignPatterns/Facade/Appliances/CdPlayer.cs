using DesignPatterns.Facade.Interfaces;

namespace DesignPatterns.Facade.Appliances;

public class CdPlayer : ICdPlayer
{
    public void On()
    {
        Console.WriteLine("Cd player is on");
    }

    public void Off()
    {
        Console.WriteLine("Cd player is off");
    }
}