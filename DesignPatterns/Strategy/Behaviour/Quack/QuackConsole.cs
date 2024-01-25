using DesignPatterns.Strategy.Interfaces;

namespace DesignPatterns.Strategy.Behaviour.Quack;

public class QuackConsole : IQuackBehaviour
{
    public void Quack()
    {
        Console.WriteLine("Quack");
    }
}