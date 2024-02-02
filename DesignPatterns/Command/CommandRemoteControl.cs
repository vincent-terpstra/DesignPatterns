using DesignPatterns.Command.Interfaces;

namespace DesignPatterns.Command;

public class CommandRemoteControl
{
    private static Action Empty = () => { };
    private static CommandAction EmptyCommand = new(Empty);
    
    private List<(ICommand On, ICommand Off)> _commands = new();
    private Action _undo = Empty;
    
    public CommandRemoteControl()
    {
        for (int i = 0; i < 10; i++)
        {
            _commands.Add((EmptyCommand, EmptyCommand));
        }
    }

    public void SetOn(int commandIndex, ICommand commandAction)
    {
        _commands[commandIndex] = (commandAction, _commands[commandIndex].Off);
    }
    
    public void SetOff(int commandIndex, ICommand commandAction)
    {
        _commands[commandIndex] = (_commands[commandIndex].On, commandAction);
    }

    public void Set(int commandIndex, ICommand on, ICommand off)
    {
        _commands[commandIndex] = (on, off);
    }
    
    
    public (Action On, Action Off) this[int i]
    {
        get
        {
            _ = ValidCommand(i);
            var cmd = _commands[i];
            return (AddUndo(cmd.On), AddUndo(cmd.Off));
        }
    }

    public void Undo()
    {
        _undo();
        _undo = Empty;
    }

    private Action AddUndo(ICommand commandAction)
    {
        return () =>
        {
            commandAction.Execute();
            _undo = commandAction.Undo;
        };
    }

    bool ValidCommand(int idx) => idx is < 10 and >= 0 ? true 
        : throw new ArgumentException("Command Remote Control can only have 10 buttons");
}