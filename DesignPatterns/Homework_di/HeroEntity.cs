using DesignPatterns.Homework_di.AttackCombos;
using DesignPatterns.Homework_di.Shields;
using DesignPatterns.Homework_di.Swords;

namespace DesignPatterns.Homework_di;

public class HeroEntity
{
    private readonly Dictionary<string, IAttackCombo> _combos;
    public Inventory Inventory { get; private set; }
    
    public HeroEntity(ISword sword, IShield shield)
    {
        Inventory = new Inventory(sword, shield);
        _combos = new Dictionary<string, IAttackCombo>();
    }
    public void AddCombo(string name, IAttackCombo combo)
    {
        _combos.TryAdd(name, combo);
    }
    
    public void ExecuteCombo(string name)
    {
        if (_combos.TryGetValue(name, out var combo))
        {
            Console.WriteLine($"Executing combo: {name}");
            combo.ExecuteCombo(Inventory);
        }
        else
        {
            throw new ArgumentException($"Combo '{name}' not found.");
        }
    }
    
    public ISword EquipSword(ISword sword)
    {
        return Inventory.EquipSword(sword);
    }
    
    public IShield EquipShield(IShield shield)
    {
        return Inventory.EquipShield(shield);
    }
}