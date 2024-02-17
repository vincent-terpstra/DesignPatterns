namespace DesignPatterns.StateV1;

public class GumballStateMainV1
{
    public static void Main()
    {
        GumballMachineV1 gumballMachine = new(5);
        
        Console.WriteLine(gumballMachine);
        
        gumballMachine.InsertQuarter();
        gumballMachine.TurnCrank();
        
        Console.WriteLine(gumballMachine);
        
        gumballMachine.InsertQuarter();
        gumballMachine.EjectQuarter();
        gumballMachine.TurnCrank();
        
        Console.WriteLine(gumballMachine);
        
        gumballMachine.InsertQuarter();
        gumballMachine.TurnCrank();
        gumballMachine.InsertQuarter();
        gumballMachine.TurnCrank();
        gumballMachine.EjectQuarter();
        
        Console.WriteLine(gumballMachine);
        
        gumballMachine.InsertQuarter();
        gumballMachine.InsertQuarter();
        gumballMachine.TurnCrank();
        gumballMachine.InsertQuarter();
        gumballMachine.TurnCrank();
        gumballMachine.InsertQuarter();
        gumballMachine.TurnCrank();
        
        Console.WriteLine(gumballMachine);
    }
}