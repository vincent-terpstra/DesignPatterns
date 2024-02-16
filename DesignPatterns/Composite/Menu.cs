namespace DesignPatterns.Composite;

public class Menu : IMenuComposite
{
    public Menu(string name, string description)
        => (Name, Description) = (name, description);
    
    public string Name { get; init; }
    public string Description { get; init; }

    private readonly List<IMenuComposite> _menuItems = new();
    
    public IEnumerable<MenuItem> GetEnumerator()
    {
        return _menuItems.SelectMany(item => item.GetEnumerator());
    }

    public IEnumerable<MenuItem> AsEnumerableYield()
    {
        foreach (var item in _menuItems)
        {
            if (item is MenuItem mi)
            {
                yield return mi;
            }
            else if(item is Menu menu){
                foreach (var subItem in menu.AsEnumerableYield())
                {
                    yield return subItem;
                }
            }
        }
    }

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