using DesignPatterns.Adapter.Interfaces;

namespace DesignPatterns.Adapter.Turkeys;

public class WildTurkey : ITurkey
{
    public void Gobble()
    {
        Console.WriteLine("Gobble gobble");
    }

    public void Fly()
    {
        Console.WriteLine("Flying a short distance");
    }
}