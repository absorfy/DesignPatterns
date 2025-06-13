using DesignPatterns.Animals;

namespace DesignPatterns.AnimalWriter;

public interface IAnimalWriteFormat
{
    public void Write(string path, params AbstractAnimal[] animals);
}