using DesignPatterns.StateV2.States;

namespace DesignPatterns.StateV2;

public class GumballMachineV2 : IGumballState
{
    public HasQuarterState HasQuarterState { get; }
    public NoQuarterState NoQuarterState { get; }
    public SoldState SoldState { get;  }
    public SoldOutState SoldOutState { get; }
    public WinnerState WinnerState { get; }

    private IGumballState _state { get; set; }
    
    public int Count { get; private set; }

    public GumballMachineV2(int count)
    {
        Count = count;
        
        HasQuarterState = new(this);
        NoQuarterState = new(this);
        SoldState = new(this);
        SoldOutState = new(this);
        WinnerState = new(this);

        _state = count > 0 ? NoQuarterState : SoldOutState;
    }

    public void SetState(IGumballState state)
    {
        _state = state;
    }

    public void ReleaseBall()
    {
        Console.WriteLine("A gumball comes rolling out the slot");
        if (Count > 0)
        {
            Count--;
            SetState(NoQuarterState);
        }
        else
        {
            SetState(SoldOutState);
        }
    }


    public void InsertQuarter() => _state.InsertQuarter();

    public void EjectQuarter() => _state.EjectQuarter();

    public void TurnCrank()
    {
        _state.TurnCrank();
        _state.Dispense();
    }

    public void Dispense() => _state.Dispense();
    
    public override string ToString()
    {
        return 
        $"""

        Mighty Gumball, Inc
        C# enable standing Gumball machine
        Inventory: {Count} gumballs    
        """;
    }
}