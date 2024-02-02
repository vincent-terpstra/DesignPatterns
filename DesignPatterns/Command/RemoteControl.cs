using DesignPatterns.Command.Interfaces;

namespace DesignPatterns.Command;

public class RemoteControl
{
    private readonly List<(Action On, Action Off)> _commands = new();
    private static Action Empty = () => { };

    public RemoteControl()
    {
        int idx = 0;
        while (ValidCommand(idx))
        {
            _commands.Add((Empty, Empty));
            idx++;
        }
    }

    public (Action On, Action Off) this[int i]
    {
        get => ValidCommand(i) ? _commands[i] : throw new ArgumentException("Remote only has 10 buttons");
        set
        {
            if(!ValidCommand(i)) throw new ArgumentException("Remote only has 10 buttons");
            _commands[i] = (
                AddUndo(value.On, value.Off), 
                AddUndo(value.Off, value.On));
        }
    }

    public void Undo()
    {
        _undo();
        _undo = Empty;
    }
    private Action _undo = Empty;
    bool ValidCommand(int idx) => idx is < 10 and >= 0;

    private Action AddUndo(Action execute, Action undo)
    {
        return () =>
        {
            _undo = undo;
            execute();
        };
    }
}