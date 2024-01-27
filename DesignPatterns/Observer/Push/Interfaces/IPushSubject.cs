namespace DesignPatterns.Observer.Push.Interfaces;

public interface IPushSubject<T>
{
    void Subscribe(IPushObserver<T> observer);
    void UnSubscribe(IPushObserver<T> observer);

    void NotifyObservers();
}