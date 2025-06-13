namespace DesignPatterns.Characters;

public interface ICharacter
{
    string Name { get; }
    string Description();
    string Attack();
}