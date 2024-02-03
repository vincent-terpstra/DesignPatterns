namespace DesignPatterns.Command.Interfaces;

public interface ICommand
{
    public static readonly Action Empty = () => { };

    public Action Execute { get; }
    public Action Undo { get; }
}