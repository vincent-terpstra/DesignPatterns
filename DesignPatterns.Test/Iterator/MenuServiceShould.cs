using DesignPatterns.Iterator;
using DesignPatterns.Iterator.Exceptions;
using DesignPatterns.Iterator.Menus;

namespace DesignPatterns.Test.Iterator;

public class MenuServiceShould
{
    public MenuServiceShould()
    {
        _menuService = new (new DinerMenu(), new PancakeHouseMenu());
    }

    private readonly MenuService _menuService;
    
    
    [Fact]
    public void Return_All_Items()
    {
        // Arrange


        // Act
        int count = _menuService.GetMenuItems().Count();

        // Assert
        count.Should().Be(8);
    }

    [Fact]
    public void Return_Breakfast_Items()
    {
        // Arrange


        // Act
        int count = _menuService.GetBreakfastMenu().Count();

        // Assert
        count.Should().Be(4);
    }
    
    [Fact]
    public void Return_Dinner_Items()
    {
        // Arrange


        // Act
        int count = _menuService.GetLunchMenuItems().Count();

        // Assert
        count.Should().Be(4);
    } 
    
    [Fact]
    public void Return_Vegetarian_Items()
    {
        // Arrange


        // Act
        var items = _menuService.GetVegetarianItems().ToList();
        int count = items.Count();
        
        // Assert
        count.Should().Be(5);
        items.Should().AllSatisfy(
            item => item.IsVegetarian.Should().BeTrue());
    }

    [Theory]
    [InlineData("Vegetarian BLT", true)]
    [InlineData("BLT", false)]
    public void Return_Item_IsVegetarian(string item, bool expected)
    {
        // Arrange


        // Act
        var isVegan = _menuService.IsItemVegetarian(item);

        // Assert
        isVegan.Should().Be(expected);
    }

    [Fact]
    public void Throw_Item_Not_Found()
    {
        // Arrange
        var action = () => _menuService.IsItemVegetarian("Not Found");

        // Act


        // Assert
        action.Should().Throw<MenuItemNotFoundException>();

    }
}