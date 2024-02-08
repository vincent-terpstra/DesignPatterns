using DesignPatterns.Adapter;
using DesignPatterns.Adapter.Interfaces;

namespace DesignPatterns.Test.Adapter;

public class TurkeyAdapterShould
{
    [Fact]
    public void Call_Gobble_On_Quack()
    {
        // Arrange
        var turkey = new Mock<ITurkey>();
        turkey.Setup(t => t.Gobble());
        TurkeyAdapter adapter = new(turkey.Object);

        // Act
        adapter.Quack();

        // Assert
        turkey.Verify(t => t.Gobble(), Times.Once);
    }
    
    [Fact]
    public void Call_Fly_Five_Times()
    {
        // Arrange
        var turkey = new Mock<ITurkey>();
        turkey.Setup(t => t.Fly());
        TurkeyAdapter adapter = new(turkey.Object);

        // Act
        adapter.Fly();

        // Assert
        turkey.Verify(t => t.Fly(), Times.Exactly(5));
    }
}