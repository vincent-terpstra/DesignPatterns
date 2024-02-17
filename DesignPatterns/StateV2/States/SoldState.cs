namespace DesignPatterns.StateV2.States;

public class SoldState : IGumballState
{
    private readonly GumballMachineV2 _gumballMachineV2;

    public SoldState(GumballMachineV2 gumballMachineV2)
    {
        _gumballMachineV2 = gumballMachineV2;
    }
    
    public void InsertQuarter()
    {
        Console.WriteLine("Please wait, we're already giving you a gumball");
    }

    public void EjectQuarter()
    {
        Console.WriteLine("You've already turned the crank");
    }

    public void TurnCrank()
    {
        Console.WriteLine("Turning twice does not get you another gumball");
    }

    public void Dispense()
    {
        _gumballMachineV2.ReleaseBall();
    }
}