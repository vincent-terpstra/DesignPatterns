namespace DesignPatterns.Template;

public abstract class CaffeineBeverage
{
    void Prepare()
    {
        BoilWater();
        Brew();
        PourInCup();
        AddFlavour();
    }

    public void BoilWater()
    {
        Console.WriteLine("Boiling water");
    }

    public abstract void Brew();

    void PourInCup()
    {
        Console.WriteLine("Pour in cup");
    }

    public abstract void AddFlavour();
}