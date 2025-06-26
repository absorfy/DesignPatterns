using Autofac;
using DesignPatterns.Homework_di.AttackCombos;
using DesignPatterns.Homework_di.Shields;
using DesignPatterns.Homework_di.Swords;

namespace DesignPatterns.Homework_di;

public class Game
{
    private ContainerBuilder _builder;
    private IContainer _container;

    public Game()
    {
        _builder = new ContainerBuilder();
    }

    public void Run()
    {
        InitializeGame();
        StartGame();
    }
    
    private void InitializeGame()
    {
        _builder.RegisterType<HeroEntity>().AsSelf();
        _builder.RegisterType<FireSword>().As<ISword>();
        _builder.RegisterType<DiamondShield>().As<IShield>();
        _builder.RegisterType<EasyCombo>().As<IEasyCombo>();
        _builder.RegisterType<HardCombo>().As<IHardCombo>();
        _container = _builder.Build();
    }

    private void StartGame()
    {
        var hero = _container.Resolve<HeroEntity>();
        hero.EquipSword(_container.Resolve<ISword>());
        hero.EquipShield(_container.Resolve<IShield>());
        
        hero.AddCombo( "easy", _container.Resolve<IEasyCombo>());
        hero.AddCombo( "hard", _container.Resolve<IHardCombo>());
        
        hero.ExecuteCombo("easy");
        hero.ExecuteCombo("hard");
    }
}