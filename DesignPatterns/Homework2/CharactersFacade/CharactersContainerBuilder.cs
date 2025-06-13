using Autofac;
using DesignPatterns.Characters;
using DesignPatterns.EchoMethods;
using DesignPatterns.Homework2.EchoMethods;

namespace DesignPatterns.Homework2.CharactersFacade;

public static class CharactersContainerBuilder
{
    public static IContainer Build()
    {
        var builder = new ContainerBuilder();

        builder.RegisterType<Knight>().Named<ICharacter>("knight");
        builder.RegisterType<Spearman>().Named<ICharacter>("spearman");
        builder.RegisterType<Archer>().Named<ICharacter>("archer");

        builder.RegisterType<ConsoleEchoMethod>().SingleInstance();
        builder.RegisterType<FileEchoMethod>().Named<IEchoMethod>("file");

        return builder.Build();
    }
}