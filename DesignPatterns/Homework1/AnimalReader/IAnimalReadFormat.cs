using DesignPatterns.Animals;

namespace DesignPatterns.AnimalReader;

public interface IAnimalReadFormat
{
    public AbstractAnimal[] Read(string path);
}