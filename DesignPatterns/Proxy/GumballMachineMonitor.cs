namespace DesignPatterns.Proxy;

public class GumballMachineMonitor
{
    private readonly GumBallMachineLocation _gumBallMachineLocation;

    public GumballMachineMonitor(GumBallMachineLocation gumBallMachineLocation)
    {
        _gumBallMachineLocation = gumBallMachineLocation;
    }

    public void Report()
    {
        Console.WriteLine($"Gumball Machine: {_gumBallMachineLocation.Location}");
        Console.WriteLine($"Current Inventory: {_gumBallMachineLocation.Count}");
        Console.WriteLine($"Current State: {_gumBallMachineLocation.CurrentState.GetType().Name}");
    }
}