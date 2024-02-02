using DesignPatterns.Command;
using DesignPatterns.Command.Appliance;

namespace DesignPatterns.Test.Command;

public class CeilingFanShould
{
    [Fact]
    public void ResetFanSpeed()
    {
        // Arrange
        CommandRemoteControl control = new();
        CeilingFan fan = new();
        
        control.Set(0, fan.TurnOff, fan.LowSpeed);
        control.Set(1, fan.MediumSpeed, fan.HighSpeed);
        
        // Act
        // Assert
        control[0].On();
        fan.Speed.Should().Be(CeilingFanState.OFF);
        control[0].Off();
        fan.Speed.Should().Be(CeilingFanState.LOW);
        control.Undo();
        fan.Speed.Should().Be(CeilingFanState.OFF);

        control[1].Off();
        control[1].On();
        fan.Speed.Should().Be(CeilingFanState.MEDIUM);
        control.Undo();
        fan.Speed.Should().Be(CeilingFanState.HIGH);
    }
}