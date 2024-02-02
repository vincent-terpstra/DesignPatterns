using DesignPatterns.Command;
using DesignPatterns.Command.Appliance;

namespace DesignPatterns.Test.Command;

public class RemoteControlShould
{
    [Fact]
    public void TestRemote()
    {
        // Arrange
        RemoteControl remoteControl = new();
        Light light = new Light();
        GarageDoor garageDoor = new GarageDoor();

        remoteControl[0] = (light.On, light.Off);
        remoteControl[1] = (garageDoor.Up, garageDoor.Down);

        // Act
        remoteControl[0].On();
        remoteControl[0].Off();
        remoteControl[1].On();
        remoteControl[2].Off();
        
        // Assert
        light.IsOn.Should().BeFalse();
        garageDoor.IsClosed.Should().BeFalse();
    }

    [Fact]
    public void RemoteOnlyHasTenButtons()
    {
        // Arrange
        RemoteControl remoteControl = new();
        var select = () => remoteControl[10];
        var assign = () => remoteControl[-1] = (RemoteOnlyHasTenButtons, RemoteOnlyHasTenButtons);

        // Act

        // Assert
        select.Should().Throw<ArgumentException>();
        assign.Should().Throw<ArgumentException>();
    }

    [Fact]
    public void RemoteAllowsUndo()
    {
        // Arrange
        RemoteControl remoteControl = new();
        Light light = new();

        remoteControl[0] = (light.On, light.Off);

        // Act
        // Assert
        remoteControl[0].On();
        light.IsOn.Should().BeTrue();
        remoteControl.Undo();
        light.IsOn.Should().BeFalse();

        
        remoteControl[0].Off();
        light.IsOn.Should().BeFalse();
        remoteControl.Undo();
        light.IsOn.Should().BeTrue();

        


    }
}