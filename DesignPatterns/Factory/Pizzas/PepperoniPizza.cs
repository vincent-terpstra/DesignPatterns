using DesignPatterns.Factory.Interfaces;

namespace DesignPatterns.Factory.Pizzas;

public class PepperoniPizza : Pizza
{
    public PepperoniPizza() : base("A Pizza with pepperoni")
    {
    }

    public override void Prepare(IPizzaIngredientFactory ingredientFactory)
    {
        IsPrepared = true;
        Dough = ingredientFactory.CreateDough();
        Sauce = ingredientFactory.CreateSauce();
        Cheese = ingredientFactory.CreateCheese();
        Pepperoni = ingredientFactory.CreatePepperoni();
    }
}