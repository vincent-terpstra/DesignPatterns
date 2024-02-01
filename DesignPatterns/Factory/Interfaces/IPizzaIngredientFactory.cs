using DesignPatterns.Factory.Ingredients;

namespace DesignPatterns.Factory.Interfaces;

public interface IPizzaIngredientFactory
{
    Dough CreateDough();
    Sauce CreateSauce();
    Cheese CreateCheese();
    List<Vegetable> CreateVeggies();
    Pepperoni CreatePepperoni();
    Clams CreateClams();
}