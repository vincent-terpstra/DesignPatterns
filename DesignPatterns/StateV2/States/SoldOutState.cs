namespace DesignPatterns.StateV2.States;

public class SoldOutState : IGumballState
{
    private readonly GumballMachineV2 _gumballMachineV2;

    public SoldOutState(GumballMachineV2 gumballMachineV2)
    {
        _gumballMachineV2 = gumballMachineV2;
    }

    public void InsertQuarter()
    {
        Console.WriteLine("You can't insert a quarter the machine is sold out");
    }

    public void EjectQuarter()
    {
        Console.WriteLine("You can't eject, you haven't inserted a quarter yet");
    }

    public void TurnCrank()
    {
        Console.WriteLine("You turned but there are no gumballs");
    }

    public void Dispense()
    {
        Console.WriteLine("No Gumball dispensed");
    }
}