using DesignPatterns.Homework_di.Swords;

namespace DesignPatterns.Homework_di.AttackCombos;

public class EasyCombo : IEasyCombo
{
    public void ExecuteCombo(Inventory inventory)
    {
        if (inventory.Sword == null)
        {
            throw new InvalidOperationException("Cannot execute combo without a sword.");
        }
        inventory.Sword.Attack();
        inventory.Sword.Attack();
        inventory.Sword.Attack();
    }
}