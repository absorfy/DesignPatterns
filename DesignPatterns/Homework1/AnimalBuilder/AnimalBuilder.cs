using System.Diagnostics;
using DesignPatterns.Animals;

namespace DesignPatterns.AnimalBuilder;

public static class AnimalBuilder
{
    public static AbstractAnimal Create(AnimalType type)
    {
        return type switch
        {
            AnimalType.Cat => new Cat(),
            AnimalType.Dog => new Dog(),
            _ => throw new ArgumentOutOfRangeException(nameof(type), type, null)
        };
    }
}