using DesignPatterns.Factory.Ingredients;
using DesignPatterns.Factory.Ingredients.NYIngredients;
using DesignPatterns.Factory.Ingredients.Veggies;
using DesignPatterns.Factory.Interfaces;

namespace DesignPatterns.Factory;

public class NYPizzaIngredientFactory : IPizzaIngredientFactory
{
    public Dough CreateDough()
    {
        return new ThinCrustDough();
    }

    public Sauce CreateSauce()
    {
        return new MarinaraSauce();
    }

    public Cheese CreateCheese()
    {
        return new ReggianoCheese();
    }

    public List<Vegetable> CreateVeggies()
    {
        return new List<Vegetable>()
        {
            new Garlic(),
            new Mushroom(),
            new Onion(),
            new RedPepper()
        };
    }

    public Pepperoni CreatePepperoni()
    {
        return new SlicedPepperoni();
    }

    public Clams CreateClams()
    {
        return new FreshClams();
    }
}