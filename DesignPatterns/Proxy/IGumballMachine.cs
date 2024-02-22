using DesignPatterns.StateV2;

namespace DesignPatterns.Proxy;

public interface IGumballMachine
{
    public string Location { get; }
    public IGumballState CurrentState { get; }
    public int Count { get; }
    
}