using DesignPatterns.Strategy.Behaviour.Quack;

namespace DesignPatterns.Strategy.Interfaces;

public interface IQuackBehaviour
{
    void Quack();

    static IQuackBehaviour None => new QuackNone();
}