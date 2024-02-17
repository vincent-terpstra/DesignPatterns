namespace DesignPatterns.StateV2;

public interface IGumballState
{
    void InsertQuarter();
    void EjectQuarter();
    void TurnCrank();
    void Dispense();
}