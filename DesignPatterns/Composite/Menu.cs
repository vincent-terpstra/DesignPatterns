using System.Collections;

namespace DesignPatterns.Composite;

public class Menu : IMenuComposite, IEnumerable<MenuItem>
{
    public Menu(string name, string description)
        => (Name, Description) = (name, description);
    
    public string Name { get; init; }
    public string Description { get; init; }

    private readonly List<IMenuComposite> _menuItems = new();

    public IEnumerable<MenuItem> GetMenuItems()
        => _menuItems.SelectMany(item => item.GetMenuItems());
    
    public IEnumerable<MenuItem> GetMenuItemsYield()
    {
        foreach (var item in _menuItems)
        {
            if (item is MenuItem mi)
            {
                yield return mi;
            }
            else if(item is Menu menu){
                foreach (var subItem in menu.GetMenuItemsYield())
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

    public IEnumerator<MenuItem> GetEnumerator()
    {
        return GetMenuItems().GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}