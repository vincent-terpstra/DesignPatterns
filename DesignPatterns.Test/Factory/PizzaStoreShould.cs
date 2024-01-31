using DesignPatterns.Factory;
using DesignPatterns.Factory.Pizzas;

namespace DesignPatterns.Test.Factory;

public class PizzaStoreShould
{
    [Fact]
    public void PreparePizza()
    {
        // Arrange
        PizzaFactory factory = new();
        PizzaStore store = new(factory);

        // Act
        var pizza = store.Order(PizzaType.Cheese);

        // Assert
        pizza.Should().BeOfType<CheesePizza>();
        pizza.IsReady.Should().BeTrue();
    }
}