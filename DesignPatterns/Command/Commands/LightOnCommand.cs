using DesignPatterns.Command.Appliance;
using DesignPatterns.Command.Interfaces;

namespace DesignPatterns.Command.Commands;

public class LightOnCommand : ICommand
{
    private readonly Light _light;

    public LightOnCommand(Light light)
    {
        _light = light;
    }

    public Action Execute => _light.On;

    public Action Undo => _light.Off;
}