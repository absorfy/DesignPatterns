using Autofac;
using Autofac.Core;
using DesignPatterns.Homework2.EchoMethods;
using DesignPatterns.Homework4.ContactContainer;

namespace DesignPatterns.Homework4.Contacts;

public class ContactController
{
    private static readonly IContainer Container = ContactContainerBuilder.Build();
    private readonly ILifetimeScope _scope;
    private readonly ContactView _view;
    
    public ContactController()
    {
        _scope = Container.BeginLifetimeScope();
        _view = new ContactView(_scope.Resolve<IEchoMethod>());
    }

    public Contact CreateContact(string name, string phone, string? altPhone, string email, string description)
    {
        return _scope.Resolve<Contact>(
            new NamedParameter("name", name),
            new NamedParameter("phone", phone),
            new NamedParameter("altPhone", altPhone),
            new NamedParameter("email", email),
            new NamedParameter("description", description)
        );
    }

    public void EchoContacts(params Contact[] contacts)
    {
        _view.EchoContacts(contacts);
    }
}