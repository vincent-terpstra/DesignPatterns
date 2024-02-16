namespace DesignPatterns.Composite;

public class MenuProgram
{
    public static void Main()
    {
        var allMenus = CreateMenu();
        
        //CreateMenu().Print();

        foreach (var item in allMenus.Where(i => i.IsVegetarian))
        {
            item.Print();
        }
    }

    private static Menu CreateMenu()
    {
        Menu allMenus = new Menu("ALL MENUS", "All Menus combined");

        Menu pancakeHouseMenu = new("PANCAKE HOUSE MENU", "Breakfast");
        Menu dinerMenu = new("DINER MENU", "Lunch");
        Menu cafeMenu = new("CAFE MENU", "Dinner");
        Menu dessertMenu = new("DESSERT MENU", "Dessert of Course!");
        
        allMenus.Add(pancakeHouseMenu);
        allMenus.Add(dinerMenu);
        allMenus.Add(cafeMenu);
        
        pancakeHouseMenu.Add(new MenuItem
        {
            Name = "K&B's Pancake breakfast",
            Description = "Pancakes with scrambled eggs, and toast",
            Price = 2.99m,
            IsVegetarian = true
        });
        
        pancakeHouseMenu.Add(new MenuItem
        {
            Name = "Regular Pancake breakfast",
            Description = "Pancakes with fried eggs, sausage",
            Price = 2.99m,
        });
        
        pancakeHouseMenu.Add(new MenuItem
        {
            Name = "Blueberry Pancakes",
            Description = "Pancakes made with fresh blueberries, and blueberry syrup",
            Price = 3.49m,
            IsVegetarian = true
        });
        
        pancakeHouseMenu.Add(new MenuItem
        {
            Name = "Waffles",
            Description = "Waffles, with your choice of blueberries or strawberries",
            Price = 3.59m,
            IsVegetarian = true
        });
        
       dinerMenu.Add(new MenuItem
       {
            Name = "Vegetarian BLT",
            Description = "(Fakin') Bacon with lettuce & tomato on whole wheat",
            Price = 2.99m,
            IsVegetarian = true
        });
       
       dinerMenu.Add(new MenuItem
       {
            Name = "BLT",
            Description = "Bacon with lettuce & tomato on whole wheat",
            Price = 2.99m
        });
       
       dinerMenu.Add(dessertMenu);
       
       dessertMenu.Add(new MenuItem
       {
           Name = "Apple Pie",
           Description = "Apple pie with a flakey crust, topped with vanilla ice cream",
           Price = 1.59m,
           IsVegetarian = true
       });
       
       cafeMenu.Add(new MenuItem
       {
           Name = "Veggie burger and Air fries",
           Description = "Veggie burger on a whole wheat bun, lettuce, tomato, and fries",
           Price = 3.69m,
           IsVegetarian = true
       });
        
        return allMenus;
    }
}