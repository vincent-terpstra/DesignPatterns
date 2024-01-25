using DesignPatterns.Strategy.Interfaces;

namespace DesignPatterns.Strategy.Behaviour.Quack;

public class QuackNone : IQuackBehaviour
{
    public void Quack()
    {
        // Do Nothing
    }
}