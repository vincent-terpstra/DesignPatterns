using DesignPatterns.Command.Appliance;
using DesignPatterns.Command.Commands;

namespace DesignPatterns.Test.Command;

public class MultiCommandShould
{
    [Fact]
    public void TurnOnAllEquipment()
    {
        // Arrange
        MultiCommand multiCommand = new MultiCommand();
        Television tv = new("Living Room");
        Stereo stereo = new("Dining Room");
        Light light = new();
        HotTub hotTub = new();
        
        multiCommand.AddCommand(tv.TurnOnCommand);
        multiCommand.AddCommand(stereo.TurnOnCommand);
        multiCommand.AddCommand(light.LightOnCommand);
        multiCommand.AddCommand(hotTub.TurnOnCommand);
        
        // Act
        // Assert
        multiCommand.Execute();
        tv.IsOn.Should().BeTrue();
        stereo.IsOn.Should().BeTrue();
        light.IsOn.Should().BeTrue();
        hotTub.IsOn.Should().BeTrue();

        multiCommand.Undo();
        tv.IsOn.Should().BeFalse();
        stereo.IsOn.Should().BeFalse();
        light.IsOn.Should().BeFalse();
        hotTub.IsOn.Should().BeFalse();
    }
}