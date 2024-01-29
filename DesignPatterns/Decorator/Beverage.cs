namespace DesignPatterns.Decorator;

public abstract class Beverage
{
    protected readonly string _description;
    protected readonly decimal _cost;


    protected Beverage(string description, decimal cost)
    {
        this._description = description;
        _cost = cost;
    }

    public virtual string Description => _description;

    public virtual decimal Cost => _cost;
}