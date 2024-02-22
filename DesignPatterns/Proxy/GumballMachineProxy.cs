using DesignPatterns.StateV2;

namespace DesignPatterns.Proxy;

public class GumballMachineProxy : IGumballMachine
{
    private readonly GumballMachineSkeleton _client;

    public GumballMachineProxy(GumballMachineSkeleton client)
    {
        _client = client;
    }


    public string Location => (string) _client.Send(nameof(Location));
    public IGumballState CurrentState => (IGumballState) _client.Send(nameof(CurrentState));
    public int Count => (int) _client.Send(nameof(Count));
}