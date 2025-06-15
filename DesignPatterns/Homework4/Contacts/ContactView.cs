using DesignPatterns.Homework2.EchoMethods;

namespace DesignPatterns.Homework4.Contacts;

public class ContactView 
{
    private IEchoMethod _echoMethod;
    
    public ContactView(IEchoMethod echoMethod)
    {
        _echoMethod = echoMethod;
    }

    public void SetEchoMethod(IEchoMethod echoMethod)
    {
        _echoMethod = echoMethod;
    }

    public void EchoContacts(params Contact[] contacts)
    {
        foreach (var contact in contacts)
        {
            _echoMethod.Echo(contact);
        }
    }
}