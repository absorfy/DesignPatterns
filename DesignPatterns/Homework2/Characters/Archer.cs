namespace DesignPatterns.Characters;

public class Archer : ICharacter
{
    public string Name { get; }

    public Archer(string name = "лучник")
    {
        Name = name;
    }
    
    public string Description()
    {
        return "Міткий " + Name;
    }

    public string Attack()
    {
        return Name +" вистрелив стрілою";
    }

    public override string ToString() => Description();
}