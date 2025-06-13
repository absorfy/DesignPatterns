using System.Text.Json;
using DesignPatterns.AnimalFileFormatBuilder;
using DesignPatterns.Animals;

namespace DesignPatterns.AnimalWriter;

public class JsonAnimalWriteFormat : IAnimalWriteFormat
{
    public void Write(string path, params AbstractAnimal[] animals)
    {
        var data = animals.Select(a => new AnimalDTO
        {
            Type = a.GetType().Name,
            Name = a.Name,
            Sound = a.Sound
        });

        var json = JsonSerializer.Serialize(data, new JsonSerializerOptions
        {
            WriteIndented = true
        });

        File.WriteAllText(path, json);
    }
}