using DesignPatterns.EchoMethod;

namespace DesignPatterns.Homework1.EchoMethod;

public class ConsoleEchoMethod : AbstractEchoMethod
{
    private static ConsoleEchoMethod? _instance = null;

    public static ConsoleEchoMethod Instance => _instance ??= new ConsoleEchoMethod();

    private ConsoleEchoMethod() { }
    
    public override void Echo(string message)
    {
        Console.WriteLine(message);
    }
}