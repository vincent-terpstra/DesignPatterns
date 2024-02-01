namespace DesignPatterns.Singleton;

public class SingletonPattern
{
    private SingletonPattern()
    {
        
    }

    private static SingletonPattern? _instance;
    public static SingletonPattern Instance => _instance ??= new();
}