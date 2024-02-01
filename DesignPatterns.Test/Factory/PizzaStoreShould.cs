using DesignPatterns.Factory;
using DesignPatterns.Factory.Interfaces;
using DesignPatterns.Factory.Pizzas;

namespace DesignPatterns.Test.Factory;

public class PizzaStoreShould
{
    [Fact]
    public void PreparePizza()
    {
        // Arrange
        PizzaFactory factory = new();
        IPizzaIngredientFactory ingredientFactory = new NYPizzaIngredientFactory();
        PizzaStore store = new(factory, ingredientFactory);

        // Act
        var pizza = store.Order(PizzaType.Cheese);

        // Assert
        pizza.Should().BeOfType<CheesePizza>();
        pizza.IsReady.Should().BeTrue();
    }
}