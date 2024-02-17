namespace DesignPatterns.StateV2.States;

public class WinnerState : IGumballState
{
    private readonly GumballMachineV2 _gumballMachineV2;

    public WinnerState(GumballMachineV2 gumballMachineV2)
    {
        _gumballMachineV2 = gumballMachineV2;
    }
    
    public void InsertQuarter()
    {
        Console.WriteLine("Winners don't need Quarters");
    }

    public void EjectQuarter()
    {
        Console.WriteLine("Winners don't need Quarters");
    }

    public void TurnCrank()
    {
        Console.WriteLine("Dispensing free gumball");
    }

    public void Dispense()
    {
        Console.WriteLine("YOU'RE A WINNER! you get two gumballs for your quarter!");
        _gumballMachineV2.ReleaseBall();
        _gumballMachineV2.ReleaseBall();
    }
}