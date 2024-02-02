using DesignPatterns.Command;
using DesignPatterns.Command.Appliance;

namespace DesignPatterns.Test.Command;

public class CommandRemoteControlShould
{
    [Fact]
    public void TestRemote()
    {
        // Arrange
        CommandRemoteControl commandRemoteControl = new();
        Light light = new Light();
        GarageDoor garageDoor = new GarageDoor();

        commandRemoteControl.SetOn(0, light.LightOnCommand);
        commandRemoteControl.SetOff(0, light.LightOffCommand);
        
        commandRemoteControl.SetOn(1, garageDoor.GarageDoorUpCommand);
        commandRemoteControl.SetOff(1, garageDoor.GarageDoorDownCommand);

        // Act
        commandRemoteControl[0].On();
        commandRemoteControl[0].Off();
        commandRemoteControl[1].On();
        commandRemoteControl[2].Off();
        
        // Assert
        light.IsOn.Should().BeFalse();
        garageDoor.IsClosed.Should().BeFalse();
    }

    [Fact]
    public void RemoteOnlyHasTenButtons()
    {
        // Arrange
        CommandRemoteControl commandRemoteControl = new();
        var select = () => commandRemoteControl[10];

        // Act

        // Assert
        select.Should().Throw<ArgumentException>();
    }

    [Fact]
    public void RemoteAllowsUndo()
    {
        // Arrange
        CommandRemoteControl commandRemoteControl = new();
        Light light = new();

        commandRemoteControl.SetOn(0, light.LightOnCommand);
        commandRemoteControl.SetOff(0, light.LightOffCommand);

        // Act
        // Assert
        commandRemoteControl[0].On();
        light.IsOn.Should().BeTrue();
        commandRemoteControl.Undo();
        light.IsOn.Should().BeFalse();

        
        commandRemoteControl[0].Off();
        light.IsOn.Should().BeFalse();
        commandRemoteControl.Undo();
        light.IsOn.Should().BeTrue();
    }
}