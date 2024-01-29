namespace DesignPatterns.Decorator;

public abstract class Beverage
{
    protected readonly string _description;
    protected readonly decimal _cost;
    protected Cupsize _cupsize = Cupsize.Bit;
    
    protected Beverage(string description, decimal cost)
    {
        _description = description;
        _cost = cost;
    }

    public virtual Cupsize CupSize
    {
        get => _cupsize;
        set => _cupsize = value;
    }

    public virtual string Description => _description;

    public virtual decimal Cost => _cost;
}