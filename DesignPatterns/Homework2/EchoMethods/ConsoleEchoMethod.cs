using DesignPatterns.Characters;
using DesignPatterns.Homework2.EchoMethods;

namespace DesignPatterns.EchoMethods;

public class ConsoleEchoMethod : IEchoMethod
{
    public void Echo(Object obj) 
    {
        Console.WriteLine(obj);
    }
}