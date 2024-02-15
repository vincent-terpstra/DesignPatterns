using DesignPatterns.Iterator.Exceptions;
using DesignPatterns.Iterator.Menus;

namespace DesignPatterns.Iterator;

public class MenuService
{
    private readonly DinerMenu _dinerMenu;
    private readonly PancakeHouseMenu _pancakeHouseMenu;
    
    public MenuService(DinerMenu dinerMenu, PancakeHouseMenu pancakeHouseMenu)
    {
        _dinerMenu = dinerMenu;
        _pancakeHouseMenu = pancakeHouseMenu;
    }
    
    public IEnumerable<MenuItem> GetMenuItems()
    {
        return _dinerMenu.AllItems.AsEnumerable()
            .Concat( _pancakeHouseMenu.GetItems().AsEnumerable());
    }

    public IEnumerable<MenuItem> GetBreakfastMenu()
    {
        return _pancakeHouseMenu.GetItems().AsEnumerable();
    }

    public IEnumerable<MenuItem> GetLunchMenuItems()
    {
        return _dinerMenu.AllItems.AsEnumerable();
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