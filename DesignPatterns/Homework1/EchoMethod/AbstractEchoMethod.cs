using DesignPatterns.Animals;

namespace DesignPatterns.EchoMethod;

public abstract class AbstractEchoMethod
{
    public abstract void Echo(string message);

    public void Echo(params AbstractAnimal[] animals)
    {
        foreach (var animal in animals)
        {
            Echo(animal.GetType().Name + ": " + animal);
        }
        
    }
}