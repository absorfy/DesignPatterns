namespace DesignPatterns.Homework_di.AttackCombos;

public class HardCombo : IHardCombo
{
    public void ExecuteCombo(Inventory inventory)
    {
        if(inventory.Sword == null || inventory.Shield == null)
        {
            throw new InvalidOperationException("Cannot execute combo without a sword or shield.");
        }
        inventory.Sword.Attack();
        inventory.Shield.Block();
        inventory.Sword.Attack();
        inventory.Shield.Block();
        inventory.Sword.Attack();
        inventory.Sword.Attack();
    }
}