using DesignPatterns.Strategy.Interfaces;

namespace DesignPatterns.Strategy.Behaviour.Swim;

public class SwimNone : ISwimBehaviour
{
    public void Swim()
    {
        // Do nothing
    }
}