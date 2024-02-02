namespace DesignPatterns.Command.Interfaces;

public class CommandAction : ICommand
{
    public static Action Empty = () => { };
    
    public CommandAction(Action execute, Action? undo = null)
        => (Execute, Undo) = (execute, undo ?? Empty );
    public Action Execute { get; init; }
    public Action Undo { get; init; }
}