namespace DesignPatterns.Decorator;

public class Condiment : Beverage
{
    private readonly Beverage _beverage;

    public Condiment(Beverage beverage, string description, decimal cost) : base(description, cost)
    {
        _beverage = beverage;
    }

    public override Cupsize CupSize
    {
        get => _beverage.CupSize;
        set => _beverage.CupSize = value;
    }
    public override string Description => _beverage.Description + $", {_description}";
    public override decimal Cost => _beverage.Cost + _cost;

    public static Condiment Milk(Beverage beverage) => new Condiment(beverage, "Milk", 0.20m);
    public static Condiment Soy(Beverage beverage) => new Condiment(beverage, "Soy", 0.40m);
    public static Condiment Mocha(Beverage beverage) => new Condiment(beverage, "Mocha", 0.20m);
    public static Condiment Whip(Beverage beverage) => new Condiment(beverage, "Whip", 0.50m);
}