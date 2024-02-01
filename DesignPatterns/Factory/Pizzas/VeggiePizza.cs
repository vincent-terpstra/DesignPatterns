using DesignPatterns.Factory.Interfaces;

namespace DesignPatterns.Factory.Pizzas;

public class VeggiePizza : Pizza
{
    public VeggiePizza() : base("A Vegetarian Pizza")
    {
    }

    public override void Prepare(IPizzaIngredientFactory ingredientFactory)
    {
        IsPrepared = true;
        Dough = ingredientFactory.CreateDough();
        Sauce = ingredientFactory.CreateSauce();
        Cheese = ingredientFactory.CreateCheese();
        Veggies = ingredientFactory.CreateVeggies();
    }
}