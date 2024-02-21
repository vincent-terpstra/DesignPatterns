namespace DesignPatterns.Proxy;

public class ProxyMain
{
    public static void Main()
    {
        var machine = new GumBallMachineLocation("Here", 10);
        var monitor = new GumballMachineMonitor(machine);
        
        monitor.Report();
    }
}