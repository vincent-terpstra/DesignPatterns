using DesignPatterns.Singleton;

namespace DesignPatterns.Test.Singleton;

public class SingletonShould
{
    [Fact]
    public void Only_Create_One()
    {
        var singleton1 = SingletonPattern.Instance;
        var singleton2 = SingletonPattern.Instance;

        ReferenceEquals(singleton1, singleton2).Should().BeTrue();
    }
}