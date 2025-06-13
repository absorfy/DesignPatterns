namespace DesignPatterns.Characters;

public class Spearman : ICharacter
{
    public string Name { get; }

    public Spearman(string name = "списоносець")
    {
        Name = name;
    }
    
    public string Description()
    {
        return "Прудкий " + Name;
    }

    public string Attack()
    {
        return Name + " кольнув списом";
    }

    public override string ToString() => Description();
}