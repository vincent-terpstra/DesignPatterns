using DesignPatterns.Factory.Interfaces;

namespace DesignPatterns.Factory;

public class PizzaStore
{
    private readonly IPizzaFactory _pizzaFactory;

    public PizzaStore(IPizzaFactory pizzaFactory)
    {
        _pizzaFactory = pizzaFactory;
    }

    public Pizza Order(PizzaType type)
    {
        var pizza = _pizzaFactory.Create(type);

        pizza.Prepare();
        pizza.Bake();
        pizza.Cut();
        pizza.Box();
        
        return pizza;
    }
}