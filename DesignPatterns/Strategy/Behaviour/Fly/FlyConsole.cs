using DesignPatterns.Strategy.Interfaces;

namespace DesignPatterns.Strategy.Behaviour.Fly;

public class FlyConsole : IFlyBehaviour
{
    public void Fly()
    {
        Console.WriteLine("I'm Flying!");
    }
}