namespace DesignPatterns.Template;

public class Tea : CaffeineBeverage
{
    public override void Brew() => SteepTeaBag();

    void SteepTeaBag()
    {
        Console.WriteLine("Brewing tea");
    }


    public override void AddFlavour() => AddLemon();

    void AddLemon()
    {
        Console.WriteLine("Adding lemon");
    }
}