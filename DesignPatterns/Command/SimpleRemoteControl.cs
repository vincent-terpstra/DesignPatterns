using DesignPatterns.Command.Interfaces;

namespace DesignPatterns.Command;

public class SimpleRemoteControl
{
    private ICommand? _cmdOne;

    public void SetCommandOne(ICommand command)
    {
        _cmdOne = command;
    }

    public void ButtonOnePressed() =>
        _cmdOne?.Execute();
}