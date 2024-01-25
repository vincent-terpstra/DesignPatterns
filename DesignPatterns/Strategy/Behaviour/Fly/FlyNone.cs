using DesignPatterns.Strategy.Interfaces;

namespace DesignPatterns.Strategy.Behaviour.Fly;

public class FlyNone : IFlyBehaviour
{
    public void Fly()
    {
        // Do nothing, cannot fly
    }
}