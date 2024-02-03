using DesignPatterns.Command.Interfaces;

namespace DesignPatterns.Command.Commands;

public class MultiCommand : ICommand
{
    public Action Execute { get; private set; } = ICommand.Empty;
    public Action Undo { get; private set; } = ICommand.Empty;

    public void AddCommand(ICommand command)
    {
        Execute += command.Execute;
        Undo += command.Undo;
    }
}