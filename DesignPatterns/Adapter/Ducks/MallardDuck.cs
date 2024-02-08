using DesignPatterns.Adapter.Interfaces;

namespace DesignPatterns.Adapter.Ducks;

public class MallardDuck : IDuck
{
    public void Quack()
    {
        Console.WriteLine("Quack");
    }

    public void Fly()
    {
        Console.WriteLine("Duck is airborne");
    }
}