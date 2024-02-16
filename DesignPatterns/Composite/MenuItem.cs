namespace DesignPatterns.Composite;

public class MenuItem : IMenuComposite
{
    public required string Name { get; init; }
    public required string Description { get; init; }
    public required decimal Price { get; init; }
    public bool IsVegetarian { get; init; } = false;
    
    public void Print()
    {
        string vegetarian = IsVegetarian ? "(v)" : string.Empty;
        Console.WriteLine($"  {Name} {vegetarian}, {Price:C})");
        Console.WriteLine( $" -- {Description}");
    }
}