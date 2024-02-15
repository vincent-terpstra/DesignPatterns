namespace DesignPatterns.Iterator.Menus;

public class PancakeHouseMenu
{
    private MenuItem[] menus;

    public PancakeHouseMenu()
    {
        menus = new[]
        {
            new MenuItem("K&B's Pancake Breakfast",
                "Pancakes with scrambled eggs, and toast",
                true,
                2.99m),
            new MenuItem("Regular Pancake Breakfast",
                "Pancakes with fried eggs, sausage",
                false,
                2.99m),
            new MenuItem("Blueberry Pancakes",
                "Pancakes made with fresh blueberries",
                true,
                3.49m),
            new MenuItem("Waffles",
                "Waffles, with your choice of blueberries or strawberries",
                true,
                3.59m)
        };
    }

    public void AddItem(MenuItem item)
    {
        menus = menus.Append(item).ToArray();
    }

    public MenuItem[] GetItems()
    {
        return menus;
    }
    
    
}