﻿namespace DesignPatterns.StateV2.States;

public class HasQuarterState : IGumballState
{
    private readonly GumballMachineV2 _gumballMachineV2;
    private Random _random = new Random();
    
    public HasQuarterState(GumballMachineV2 gumballMachineV2)
    {
        _gumballMachineV2 = gumballMachineV2;
    }
    
    public void InsertQuarter()
    {
        Console.WriteLine("Gumball machine already has quarter");
    }

    public void EjectQuarter()
    {
        Console.WriteLine("Ejecting quarter");
        _gumballMachineV2.SetState(_gumballMachineV2.NoQuarterState);
    }

    public void TurnCrank()
    {
        Console.WriteLine("Turning crank");
        
        _gumballMachineV2.SetState(_random.Next(0,10) == 0 ? _gumballMachineV2.WinnerState :_gumballMachineV2.SoldState);
    }

    public void Dispense()
    {
        Console.WriteLine("No gumball dispensed");
    }
}