using DesignPatterns.Factory.Ingredients;
using DesignPatterns.Factory.Interfaces;

namespace DesignPatterns.Factory;

public abstract class Pizza
{
    private readonly string _description;

    public Dough Dough { get; set; }
    public Sauce Sauce { get; set; }
    public List<Vegetable> Veggies { get; set; }
    public Cheese Cheese { get; set; }
    public Pepperoni Pepperoni { get; set; }
    public Clams Clams { get; set; }
    
    protected bool IsPrepared;
    private bool _isBaked;
    private bool _isCut;
    private bool _isBoxed;

    public abstract void Prepare(IPizzaIngredientFactory ingredientFactory);

    protected Pizza(string description)
    {
        _description = description;
    }
    
    public void Bake()
    {
        if (!IsPrepared)
            throw new PizzaStateException("Pizza must be prepared before being baked");
        
        Console.WriteLine("Bake for 25 minutes at 350");
        _isBaked = true;
    }

    public void Cut()
    {
        if (!_isBaked)
            throw new PizzaStateException("Pizza must be baked before being cut");
        
        Console.WriteLine("Cutting the pizza into diagonal slices");
        _isCut = true;
    }

    public void Box()
    {
        if (!IsReady)
            throw new PizzaStateException("Pizza must be ready before being boxed");
        
        Console.WriteLine("Place pizza in official Pizza Store box");
        _isBoxed = true;
    }

    public bool IsReady => IsPrepared && _isBaked && _isCut;
}