using Autofac;
using DesignPatterns.Characters;
using DesignPatterns.EchoMethods;
using DesignPatterns.Homework2.CharactersFacade;
using DesignPatterns.Homework2.EchoMethods;

namespace DesignPatterns.CharactersFacade;

public class CharactersFacade
{
    private static readonly IContainer Container = CharactersContainerBuilder.Build();
    private ILifetimeScope? scope = null;
    
    public void BeginLifetimeScope()
    {
        scope = Container.BeginLifetimeScope();
    }

    public void Run()
    {
        if (scope == null)
        {
            throw new Exception("Lifetime scope is was not started");
        }
        
        var knight = scope.ResolveNamed<ICharacter>("knight");
        var archer = scope.ResolveNamed<ICharacter>("archer");
        var spearman = scope.ResolveNamed<ICharacter>("spearman");

        var console = scope.Resolve<ConsoleEchoMethod>();
        var file = scope.ResolveNamed<IEchoMethod>("file");
    
        console.Echo(knight);
        console.Echo(archer);
        console.Echo(spearman);
        file.Echo(knight.Attack());
        file.Echo(archer.Attack());
        file.Echo(spearman.Attack());
    }
}