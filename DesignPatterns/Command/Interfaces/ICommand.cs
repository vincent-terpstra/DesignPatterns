namespace DesignPatterns.Command.Interfaces;

public interface ICommand 
{
    public Action Execute { get; }
    public Action Undo { get; }
}