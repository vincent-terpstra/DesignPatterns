namespace DesignPatterns.Iterator.Menus;

public class DinerMenu : IMenu
{
    private List<MenuItem> _items;

    public DinerMenu()
    {
        _items = new();
        
        AddItem(new MenuItem("Vegetarian BLT",
            "(Fakin') Bacon with lettuce & tomato on whole wheat",
            true, 
            2.99m));
        
        AddItem(new MenuItem("BLT",
            "Bacon with lettuce & tomato on whole wheat",
            false, 
            2.99m));
        
        AddItem(new MenuItem("Soup of the day",
            "Soup of the day, with a side of potato salad",
            true, 
            3.29m));
        
        AddItem(new MenuItem("Hotdog",
            "A hot dog, with saurkraut, relish, onions, topped with cheese",
            false, 
            3.05m));
    }

    public void AddItem(MenuItem item)
    {
        _items.Add(item);
    }

    public IReadOnlyList<MenuItem> AllItems => _items.AsReadOnly();
    public IEnumerable<MenuItem> MenuItems => _items.AsEnumerable();
}