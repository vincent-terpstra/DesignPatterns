using DesignPatterns.Command.Interfaces;

namespace DesignPatterns.Command.Appliance;

public class CeilingFan
{
    public CeilingFanState Speed { get; private set; } = CeilingFanState.OFF;

    private CeilingFanState _previousSpeed = CeilingFanState.OFF;

    public void Reset()
    {
        Speed = _previousSpeed;
    }

    private void SetSpeed(CeilingFanState speed)
    {
        _previousSpeed = Speed;
        Speed = speed;
    }
    
    public CommandAction TurnOff => new(() => SetSpeed(CeilingFanState.OFF), Reset);
    public CommandAction HighSpeed => new(() => SetSpeed(CeilingFanState.HIGH), Reset);
    public CommandAction MediumSpeed => new(() => SetSpeed(CeilingFanState.MEDIUM), Reset);
    public CommandAction LowSpeed => new(() => SetSpeed(CeilingFanState.LOW), Reset);
}

public enum CeilingFanState
{
    HIGH,
    MEDIUM,
    LOW,
    OFF
}