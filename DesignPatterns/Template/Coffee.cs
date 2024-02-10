namespace DesignPatterns.Template;

public class Coffee : CaffeineBeverage
{

    public override void Brew()
    {
        Console.WriteLine("Brewing coffee");
    }

    public override void AddFlavour()
    {
        Console.WriteLine("Adding sugar and milk");
    }
}