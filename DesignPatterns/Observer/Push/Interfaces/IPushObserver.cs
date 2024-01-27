namespace DesignPatterns.Observer.Push.Interfaces;

public interface IPushObserver<T>
{
    public void Update(T update);
}