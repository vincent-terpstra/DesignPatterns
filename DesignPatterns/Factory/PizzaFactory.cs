using DesignPatterns.Factory.Pizzas;

namespace DesignPatterns.Factory;

public class PizzaFactory
{
    public Pizza Create(PizzaType type)
    {
        return type switch
        {
            PizzaType.Cheese => new CheesePizza(),
            PizzaType.Pepperoni => new PepperoniPizza(),
            PizzaType.Veggie => new PepperoniPizza(),
            _ => throw new ArgumentException($"Unable to create pizza of type {type}")
        };
    }
}