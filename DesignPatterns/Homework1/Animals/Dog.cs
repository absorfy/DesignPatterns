namespace DesignPatterns.Animals;

public class Dog : AbstractAnimal
{
    public override string Name { get; protected set; }
    public override string Sound { get; protected set; } = "woof";
}