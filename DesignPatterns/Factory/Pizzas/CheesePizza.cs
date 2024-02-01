using DesignPatterns.Factory.Interfaces;

namespace DesignPatterns.Factory.Pizzas;

public class CheesePizza : Pizza
{
    public CheesePizza() : base("A Pizza with Cheese")
    {
    }

    public override void Prepare(IPizzaIngredientFactory ingredientFactory)
    {
        IsPrepared = true;
        Dough = ingredientFactory.CreateDough();
        Sauce = ingredientFactory.CreateSauce();
        Cheese = ingredientFactory.CreateCheese();

    }
}