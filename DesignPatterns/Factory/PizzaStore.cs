using DesignPatterns.Factory.Interfaces;

namespace DesignPatterns.Factory;

public class PizzaStore
{
    private readonly IPizzaFactory _pizzaFactory;
    private readonly IPizzaIngredientFactory _pizzaIngredientFactory;

    public PizzaStore(IPizzaFactory pizzaFactory, IPizzaIngredientFactory pizzaIngredientFactory)
    {
        _pizzaFactory = pizzaFactory;
        _pizzaIngredientFactory = pizzaIngredientFactory;
    }

    public Pizza Order(PizzaType type)
    {
        var pizza = _pizzaFactory.Create(type);

        pizza.Prepare(_pizzaIngredientFactory);
        pizza.Bake();
        pizza.Cut();
        pizza.Box();
        
        return pizza;
    }
}