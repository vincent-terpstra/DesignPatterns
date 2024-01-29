using DesignPatterns.Strategy;
using DesignPatterns.Strategy.Interfaces;

namespace DesignPatterns.Test.Strategy;

public class DuckShould
{
    [Fact]
    public void On_Quack_Should_Call_Quack()
    {
        // Arrange 
        var quack = new Mock<IQuackBehaviour>();
            quack.Setup(q => q.Quack());
            Duck duck = new Duck(quackBehaviour: quack.Object);

        // Act
        duck.Quack();

        // Assert
        quack.Verify(q => q.Quack(), Times.Once);
    }

    [Fact]
    public void Allow_Swim_Behaviour_Switched()
    {
        // Arrange
        var swim = new Mock<ISwimBehaviour>();
            swim.Setup(s => s.Swim());
            
        var replace = new Mock<ISwimBehaviour>();
            replace.Setup(s => s.Swim());
            
        Duck duck = new Duck(swimBehaviour: swim.Object);
        
        // Act
        duck.SwimBehaviour = replace.Object;
        duck.Swim();
        
        // Assert
        swim.Verify(s => s.Swim(), Times.Never);
        replace.Verify(s => s.Swim(), Times.Once);
    }
}