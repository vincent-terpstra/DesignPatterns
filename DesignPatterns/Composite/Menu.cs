namespace DesignPatterns.Composite;

public class Menu : IMenuComposite
{
    public Menu(string name, string description)
        => (Name, Description) = (name, description);
    
    public string Name { get; init; }
    public string Description { get; init; }

    private readonly List<IMenuComposite> _menuItems = new();
    
    public void Print()
    {
        Console.WriteLine();
        Console.WriteLine($"{Name}, {Description}");
        Console.WriteLine("-----------------------------------");
        foreach (var item in _menuItems)
        {
            item.Print();
        }
        
    }

    public void Add(IMenuComposite item)
    {
        _menuItems.Add(item);
    }

    public void Remove(IMenuComposite item)
    {
        _menuItems.Remove(item);
    }
}