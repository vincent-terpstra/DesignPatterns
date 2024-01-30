namespace DesignPatterns.Factory;

public class PizzaStore
{
    private readonly PizzaFactory _pizzaFactory;

    public PizzaStore(PizzaFactory pizzaFactory)
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