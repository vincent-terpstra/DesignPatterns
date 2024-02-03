namespace DesignPatterns.Command.Interfaces;

public class CommandAction : ICommand
{
    
    public CommandAction(Action execute, Action? undo = null)
        => (Execute, Undo) = (execute, undo ?? ICommand.Empty );
    public Action Execute { get; init; }
    public Action Undo { get; init; }
}