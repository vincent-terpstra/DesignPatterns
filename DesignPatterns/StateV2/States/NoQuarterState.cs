namespace DesignPatterns.StateV2.States;

public class NoQuarterState : IGumballState
{
    private readonly GumballMachineV2 _gumballMachineV2;

    public NoQuarterState(GumballMachineV2 gumballMachineV2)
    {
        _gumballMachineV2 = gumballMachineV2;
    }
    
    public void InsertQuarter()
    {
        Console.WriteLine("You inserted a quarter");
        _gumballMachineV2.SetState(_gumballMachineV2.HasQuarterState);
    }

    public void EjectQuarter()
    {
        Console.WriteLine("No quarter to eject");
    }

    public void TurnCrank()
    {
        Console.WriteLine("You turned but there is no quarter");
    }

    public void Dispense()
    {
        Console.WriteLine("You need to pay first");
    }
}