using Autofac;
using DesignPatterns.Homework2.EchoMethods;
using DesignPatterns.Homework3.Notes;
using DesignPatterns.Homework4.Contacts;

namespace DesignPatterns.Homework4.ContactContainer;

public static class ContactContainerBuilder
{
    public static IContainer Build()
    {
        var builder = new ContainerBuilder();
        builder.RegisterType<Contact>();
        builder.RegisterType<EchoMethodFacade>().As<IEchoMethod>().SingleInstance();
        return builder.Build();
    }
}