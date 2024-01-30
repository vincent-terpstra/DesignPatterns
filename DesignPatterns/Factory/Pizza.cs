namespace DesignPatterns.Factory;

public abstract class Pizza
{
    private readonly string _description;
    private bool _isPrepared;
    private bool _isBaked;
    private bool _isCut;
    private bool _isBoxed;

    protected Pizza(string description)
    {
        _description = description;
    }

    public void Prepare()
    {
        _isPrepared = true;
    }

    public void Bake()
    {
        if (!_isPrepared)
            throw new PizzaStateException("Pizza must be prepared before being baked");
        
        _isBaked = true;
    }

    public void Cut()
    {
        if (!_isBaked)
            throw new PizzaStateException("Pizza must be baked before being cut");
        
        _isCut = true;
    }

    public void Box()
    {
        if (!IsReady)
            throw new PizzaStateException("Pizza must be ready before being boxed");
        
        _isBoxed = true;
    }

    public bool IsReady => _isPrepared && _isBaked && _isCut;
}