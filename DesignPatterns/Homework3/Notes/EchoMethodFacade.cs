using DesignPatterns.EchoMethods;
using DesignPatterns.Homework2.EchoMethods;

namespace DesignPatterns.Homework3.Notes;

public class EchoMethodFacade : IEchoMethod
{
    private readonly IEchoMethod[] _echoMethods = [new ConsoleEchoMethod(), new FileEchoMethod()];
    
    public void Echo(object obj)
    {
        foreach (var echoMethod in _echoMethods)
        {
            echoMethod.Echo(obj);
        }
    }
}