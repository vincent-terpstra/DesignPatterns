using DesignPatterns.Strategy.Interfaces;

namespace DesignPatterns.Strategy.Behaviour.Swim;

public class SwimConsole : ISwimBehaviour
{
    public void Swim()
    {
        Console.WriteLine("Swimming");
    }
}