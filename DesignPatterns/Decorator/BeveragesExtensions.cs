namespace DesignPatterns.Decorator;

public static class BeveragesExtensions
{
    public static Beverage AddMilk(this Beverage beverage)
        => Condiment.Milk(beverage);
    
    public static Beverage AddMocha(this Beverage beverage)
        => Condiment.Mocha(beverage);
    
    public static Beverage AddSoy(this Beverage beverage)
        => Condiment.Soy(beverage);
    
    public static Beverage AddWhip(this Beverage beverage)
        => Condiment.Whip(beverage);
    
}