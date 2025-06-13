using DesignPatterns.Animals;

namespace DesignPatterns.AnimalWriter;

public class PlainTextAnimalWriteFormat : IAnimalWriteFormat
{
    public void Write(string path, params AbstractAnimal[] animals)
    {
        using var writer = new StreamWriter(path);
        foreach (var animal in animals)
        {
            writer.WriteLine($"{animal.GetType().Name}: {animal}");
        }
    }
}