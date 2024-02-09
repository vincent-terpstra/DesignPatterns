using DesignPatterns.Facade.Interfaces;

namespace DesignPatterns.Facade.Appliances;

public class Screen : IScreen
{
    public void Up()
    {
        Console.WriteLine("Screen is down");
    }

    public void Down()
    {
        Console.WriteLine("Screen is up");
    }
}