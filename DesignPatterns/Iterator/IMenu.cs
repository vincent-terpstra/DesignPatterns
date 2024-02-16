namespace DesignPatterns.Iterator;

public interface IMenu
{
    IEnumerable<MenuItem> MenuItems { get; }
}