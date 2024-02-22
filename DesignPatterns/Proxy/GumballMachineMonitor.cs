namespace DesignPatterns.Proxy;

public class GumballMachineMonitor
{
    private readonly IGumballMachine _gumBallMachine;

    public GumballMachineMonitor(IGumballMachine gumBallMachine)
    {
        _gumBallMachine = gumBallMachine;
    }

    public void Report()
    {
        Console.WriteLine($"Gumball Machine: {_gumBallMachine.Location}");
        Console.WriteLine($"Current Inventory: {_gumBallMachine.Count}");
        Console.WriteLine($"Current State: {_gumBallMachine.CurrentState.GetType().Name}");
    }
}