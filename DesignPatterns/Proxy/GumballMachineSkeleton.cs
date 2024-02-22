namespace DesignPatterns.Proxy;

public class GumballMachineSkeleton
{
    private readonly GumBallMachineLocation _gumBallMachine;

    public GumballMachineSkeleton(GumBallMachineLocation gumBallMachine)
    {
        _gumBallMachine = gumBallMachine;
    }

    public object Send(string request)
    {
        return request switch
        {
            nameof(IGumballMachine.Location) => _gumBallMachine.Location,
            nameof(IGumballMachine.CurrentState) => _gumBallMachine.CurrentState,
            nameof(IGumballMachine.Count) => _gumBallMachine.Count,
            _=> throw new ArgumentException($"unable to determine request {request}")
        };
    }
}