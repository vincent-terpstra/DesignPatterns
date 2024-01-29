using DesignPatterns.Decorator;
using DesignPatterns.Decorator.Beverages;

namespace DesignPatterns.Test.Decorator;

public class BeveragesShould
{
    [Fact]
    public void Soy_Milk_Decaf()
    {
        Beverage soy_milk_decaf = new Decaf()
            .AddMilk()
            .AddSoy();

        soy_milk_decaf.Cost.Should().Be(2.10m);
        soy_milk_decaf.Description.Should().Be("Decaf Coffee, Milk, Soy");
    }
    
    [Fact]
    public void DarkRoast_Mocha_Whip()
    {
        Beverage DarkRoast_Mocha_Whip = new DarkRoast()
            .AddMocha()
            .AddWhip();

        DarkRoast_Mocha_Whip.Cost.Should().Be(2.20m);
        DarkRoast_Mocha_Whip.Description.Should().Be("Dark Roast Coffee, Mocha, Whip");
    }
}