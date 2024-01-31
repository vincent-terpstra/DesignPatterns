namespace DesignPatterns.Factory.Interfaces;

public interface IPizzaFactory
{
    public Pizza Create(PizzaType type);
}