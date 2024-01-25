using DesignPatterns.Strategy.Behaviour.Fly;

namespace DesignPatterns.Strategy.Interfaces;

public interface IFlyBehaviour
{
    void Fly();

    public static IFlyBehaviour None => new FlyNone();
}