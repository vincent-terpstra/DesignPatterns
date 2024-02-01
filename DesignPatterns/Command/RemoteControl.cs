using DesignPatterns.Command.Interfaces;

namespace DesignPatterns.Command;

public class RemoteControl
{
    private readonly List<(Action On, Action Off)> _commands = new();

    public RemoteControl()
    {
        var empty = () => { };
        int idx = 0;
        while (ValidCommand(idx))
        {
            _commands.Add((empty, empty));
            idx++;
        }
    }

    public (Action On, Action Off) this[int i]
    {
        get => ValidCommand(i) ? _commands[i] : throw new ArgumentException("Remote only has 10 buttons");
        set => _commands[i] = ValidCommand(i) ? value : throw new ArgumentException("Remote only has 10 buttons");
    }
    
    bool ValidCommand(int idx) => idx is < 10 and >= 0;
}