namespace DesignPatterns.Proxy;

public class ProxyMain
{
    public static void Main()
    {
        Console.WriteLine("Using interface");
        var machine = new GumBallMachineLocation("Here", 10);
        var monitor = new GumballMachineMonitor(machine);

        Console.WriteLine();
        Console.WriteLine("Using Proxy");
        var skeleton = new GumballMachineSkeleton(machine);
        var proxy = new GumballMachineProxy(skeleton);

        var proxyMonitor = new GumballMachineMonitor(proxy);
        
        proxyMonitor.Report();
        
        monitor.Report();
    }
}