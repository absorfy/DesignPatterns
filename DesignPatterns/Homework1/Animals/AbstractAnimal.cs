using DesignPatterns.EchoMethod;

namespace DesignPatterns.Animals;

public abstract class AbstractAnimal
{
    public abstract string Name { get; protected set; }
    public abstract string Sound { get; protected set; }

    public void EchoName(AbstractEchoMethod echoMethod)
    {
        echoMethod.Echo(Name);
    }

    public void EchoSound(AbstractEchoMethod echoMethod)
    {
        echoMethod.Echo(Sound);
    }

    public AbstractAnimal SetName(string name)
    {
        Name = name;
        return this;
    }

    public AbstractAnimal SetSound(string sound)
    {
        Sound = sound;
        return this;
    }

    public override string ToString()
        => $"name: {Name}, sound: {Sound}";
}