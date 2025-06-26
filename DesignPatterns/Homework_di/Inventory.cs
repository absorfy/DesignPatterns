using DesignPatterns.Homework_di.Shields;
using DesignPatterns.Homework_di.Swords;

namespace DesignPatterns.Homework_di;

public class Inventory
{
    public ISword Sword { get; private set; }
    public IShield Shield { get; private set; }
    
    public Inventory(ISword sword, IShield shield)
    {
        Sword = sword;
        Shield = shield;
    }
    
    public ISword EquipSword(ISword sword)
    {
        var oldSWord = Sword;
        Sword = sword;
        return oldSWord;
    }
    
    public IShield EquipShield(IShield shield)
    {
        var oldShield = Shield;
        Shield = shield;
        return oldShield;
    }
}