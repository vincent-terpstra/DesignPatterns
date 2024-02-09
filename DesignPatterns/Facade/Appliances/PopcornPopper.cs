using DesignPatterns.Facade.Interfaces;

namespace DesignPatterns.Facade.Appliances;

public class PopcornPopper : IPopcornPopper
{
    public void On()
    {
        Console.WriteLine("Popper is on");
    }

    public void Off()
    {
        Console.WriteLine("Popper is Off");
    }

    public void Pop()
    {
        foreach (var i in Enumerable.Range(1, 5))
        {
            Console.WriteLine("Pop");
        }
    }
}