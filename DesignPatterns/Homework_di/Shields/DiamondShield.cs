namespace DesignPatterns.Homework_di.Shields;

public class DiamondShield : IShield
{
    public void Block()
    {
        Console.WriteLine("Blocking with a diamond shield! It's strong and elegant.");
    }
}