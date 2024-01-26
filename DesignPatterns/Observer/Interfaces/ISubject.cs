namespace DesignPatterns.Observer.Interfaces;

public interface ISubject
{
    public void Register(IObserver observer);
    public void Remove(IObserver observer);
    public void NotifyObservers();
}