using DesignPatterns.Strategy.Behaviour.Swim;

namespace DesignPatterns.Strategy.Interfaces;

public interface ISwimBehaviour
{
    void Swim();

    static ISwimBehaviour None => new SwimNone();
}