namespace DesignPatterns.StateV1;

public class GumballMachineV1
{
    private int _count { get; set; }

    public GumballMachineV1(int count)
    {
        _count = count;
        CurrentState = _count > 0 ? GumballState.NO_QUARTER : GumballState.SOLD_OUT;
    }

    public override string ToString()
    {
        return 
        $"""

        Mighty Gumball, Inc
        C# enable standing Gumball machine
        Inventory: {_count} gumballs    
        """;
    }

    public GumballState CurrentState { get; private set; } = GumballState.SOLD_OUT;

    public void InsertQuarter()
    {
        if (CurrentState == GumballState.HAS_QUARTER)
        {
            Console.WriteLine("You can't insert another quarter");
        }
        else if (CurrentState == GumballState.SOLD_OUT)
        {
            Console.WriteLine("You can't insert a quarter, the machine is sold out");
        }
        else if (CurrentState == GumballState.SOLD)
        {
            Console.WriteLine("Please wait, we're already giving you a gumball");
        }
        else if (CurrentState == GumballState.NO_QUARTER)
        {
            CurrentState = GumballState.HAS_QUARTER;
            Console.WriteLine("You inserted a quarter");
        }
    }

    public void EjectQuarter()
    {
        switch (CurrentState)
        {
            case GumballState.HAS_QUARTER:
                Console.WriteLine("Quarter returned");
                CurrentState = GumballState.NO_QUARTER;
                break;
            case GumballState.SOLD:
                Console.WriteLine("Sorry you've already turned the crank");
                break;
            case GumballState.SOLD_OUT:
                Console.WriteLine("You turned but there are no gumballs");
                break;
            case GumballState.NO_QUARTER:
                Console.WriteLine("You can't eject, you haven't inserted a quarter");
                break;
        }
    }

    public void TurnCrank()
    {
        switch (CurrentState)
        {
            case GumballState.SOLD:
                Console.WriteLine("Turning twice doesn't get you another gumball");
                break;
            case GumballState.NO_QUARTER:
                Console.WriteLine("You turned but there is no quarter");
                break;
            case GumballState.SOLD_OUT:
                Console.WriteLine("You turned but there are no gumballs");
                break;
            case GumballState.HAS_QUARTER:
                Console.WriteLine("You turn the crank");
                CurrentState = GumballState.SOLD;
                Dispense();
                break;
        }
    }

    private void Dispense()
    {
        switch (CurrentState)
        {
            case GumballState.SOLD:
                Console.WriteLine("A gumball comes rolling out the slot");
                if (--_count == 0)
                {
                    Console.WriteLine("Oops, out of gumballs");
                    CurrentState = GumballState.SOLD_OUT;
                }
                else
                {
                    CurrentState = GumballState.NO_QUARTER;
                }
                break;
            case GumballState.NO_QUARTER:
                Console.WriteLine("You need to pay first");
                break;
            case GumballState.SOLD_OUT:
                Console.WriteLine("No Gumball dispensed");
                break;
            case GumballState.HAS_QUARTER:
                Console.WriteLine("No Gumball dispensed");
                break;
        }
    }
}