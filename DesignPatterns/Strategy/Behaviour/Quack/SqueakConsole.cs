using DesignPatterns.Strategy.Interfaces;

namespace DesignPatterns.Strategy.Behaviour.Quack;

public class SqueakConsole : IQuackBehaviour
{
    public void Quack()
    {
        Console.WriteLine("Squeak");
    }
}