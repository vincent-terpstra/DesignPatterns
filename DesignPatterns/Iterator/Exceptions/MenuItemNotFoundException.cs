namespace DesignPatterns.Iterator.Exceptions;

public class MenuItemNotFoundException : Exception
{
    public MenuItemNotFoundException(string item) : base($"Unable to find {item}")
    {
        
    }
}