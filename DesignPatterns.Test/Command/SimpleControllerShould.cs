using DesignPatterns.Command;
using DesignPatterns.Command.Appliance;
using DesignPatterns.Command.Commands;

namespace DesignPatterns.Test.Command;

public class SimpleControllerShould
{
    [Fact]
    public void TurnOnLight()
    {
        // Arrange
        Light light = new Light();
        LightOnCommand on = new LightOnCommand(light);
        SimpleRemoteControl remote = new();
        
        // Act
        remote.SetCommandOne(on);
        remote.ButtonOnePressed();

        // Assert
        light.IsOn.Should().BeTrue();
    }
    
    [Fact]
    public void TurnOnGarage()
    {
        // Arrange
        GarageDoor door = new();
        SimpleRemoteControl remote = new();
        
        // Act
        remote.SetCommandOne(door);
        remote.ButtonOnePressed();

        // Assert
        door.IsClosed.Should().BeFalse();
    }
}