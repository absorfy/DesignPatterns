namespace DesignPatterns.Characters;

public class Knight : ICharacter
{
    public string Name { get; }

    public Knight(string name = "рицар")
    {
        Name = name;
    }
    
    public string Description()
    {
        return "Хоробрий " + Name;
    }

    public string Attack()
    {
        return Name + " махнув мечем";
    }

    public override string? ToString() => Description();
}