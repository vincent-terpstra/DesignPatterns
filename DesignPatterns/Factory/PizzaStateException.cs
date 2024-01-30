namespace DesignPatterns.Factory;

public class PizzaStateException : Exception
{
    public PizzaStateException(string message) : base(message)
    {
    }
}