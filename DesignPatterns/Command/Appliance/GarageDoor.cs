using DesignPatterns.Command.Interfaces;

namespace DesignPatterns.Command.Appliance;

public class GarageDoor : ICommand
{
    private bool _isUp;
    public bool IsClosed => !_isUp;
    
    public void Up()
    {
        _isUp = true;
        Console.WriteLine("Opening Garage Door");
    }

    public void Down()
    {
        _isUp = false;
        Console.WriteLine("Closing Garage Door");
    }

    public CommandAction GarageDoorUpCommand => new(Up, Down);
    public CommandAction GarageDoorDownCommand => new(Down, Up);
    

    Action ICommand.Execute => Up;

    Action ICommand.Undo => Down;
}