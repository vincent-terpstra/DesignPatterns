using DesignPatterns.Command;
using DesignPatterns.Command.Appliance;

namespace DesignPatterns.Test.Command;

public class ActionRemoteControlShould
{
    [Fact]
    public void TestRemote()
    {
        // Arrange
        ActionRemoteControl actionRemoteControl = new();
        Light light = new Light();
        GarageDoor garageDoor = new GarageDoor();

        actionRemoteControl[0] = (light.On, light.Off);
        actionRemoteControl[1] = (garageDoor.Up, garageDoor.Down);

        // Act
        actionRemoteControl[0].On();
        actionRemoteControl[0].Off();
        actionRemoteControl[1].On();
        actionRemoteControl[2].Off();
        
        // Assert
        light.IsOn.Should().BeFalse();
        garageDoor.IsClosed.Should().BeFalse();
    }

    [Fact]
    public void RemoteOnlyHasTenButtons()
    {
        // Arrange
        ActionRemoteControl actionRemoteControl = new();
        var select = () => actionRemoteControl[10];
        var assign = () => actionRemoteControl[-1] = (RemoteOnlyHasTenButtons, RemoteOnlyHasTenButtons);

        // Act

        // Assert
        select.Should().Throw<ArgumentException>();
        assign.Should().Throw<ArgumentException>();
    }

    [Fact]
    public void RemoteAllowsUndo()
    {
        // Arrange
        ActionRemoteControl actionRemoteControl = new();
        Light light = new();

        actionRemoteControl[0] = (light.On, light.Off);

        // Act
        // Assert
        actionRemoteControl[0].On();
        light.IsOn.Should().BeTrue();
        actionRemoteControl.Undo();
        light.IsOn.Should().BeFalse();

        
        actionRemoteControl[0].Off();
        light.IsOn.Should().BeFalse();
        actionRemoteControl.Undo();
        light.IsOn.Should().BeTrue();

        


    }
}