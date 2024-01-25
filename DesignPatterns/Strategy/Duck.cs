using DesignPatterns.Strategy.Interfaces;

namespace DesignPatterns.Strategy;

public class Duck : IFlyBehaviour, ISwimBehaviour, IQuackBehaviour
{
    
    public IQuackBehaviour QuackBehaviour { get; set; }
    public ISwimBehaviour SwimBehaviour { get; set; }
    public IFlyBehaviour FlyBehaviour { get; set; }

    public Duck(
        
        IQuackBehaviour? quackBehaviour = null, 
        ISwimBehaviour? swimBehaviour = null,
        IFlyBehaviour? flyBehaviour = null )
    {
        
        QuackBehaviour = quackBehaviour ?? IQuackBehaviour.None;
        SwimBehaviour = swimBehaviour ?? ISwimBehaviour.None;
        FlyBehaviour = flyBehaviour ?? IFlyBehaviour.None;
    }


    public void Swim() => SwimBehaviour.Swim();

    public void Quack() => QuackBehaviour.Quack();

    public void Fly() => FlyBehaviour.Fly();
}