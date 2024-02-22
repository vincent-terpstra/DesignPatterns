using DesignPatterns.StateV2;

namespace DesignPatterns.Proxy;

public class GumBallMachineLocation : GumballMachineV2, IGumballMachine
{
    public string Location { get; }

    public GumBallMachineLocation(string location, int count) : base(count)
    {
        Location = location;
    }
    
    
}