using DesignPatterns.Iterator.Exceptions;
using DesignPatterns.Iterator.Menus;

namespace DesignPatterns.Iterator;

public class MenuService
{
    private readonly IMenu _dinerMenu;
    private readonly IMenu _pancakeHouseMenu;
    
    public MenuService(IMenu dinerMenu, IMenu pancakeHouseMenu)
    {
        _dinerMenu = dinerMenu;
        _pancakeHouseMenu = pancakeHouseMenu;
    }
    
    public IEnumerable<MenuItem> GetMenuItems()
    {
        return _dinerMenu.MenuItems
            .Concat( _pancakeHouseMenu.MenuItems);
    }

    public IEnumerable<MenuItem> GetBreakfastMenu()
    {
        return _pancakeHouseMenu.MenuItems;
    }

    public IEnumerable<MenuItem> GetLunchMenuItems()
    {
        return _dinerMenu.MenuItems;
    }

    public IEnumerable<MenuItem> GetVegetarianItems()
    {
        return GetMenuItems().Where(item => item.IsVegetarian);
    }

    public bool IsItemVegetarian(string query)
    {
        return GetMenuItems().FirstOrDefault(item => item.Name == query)?.IsVegetarian 
               ?? throw new MenuItemNotFoundException($"Unable to find menu item {query}");
    }

}