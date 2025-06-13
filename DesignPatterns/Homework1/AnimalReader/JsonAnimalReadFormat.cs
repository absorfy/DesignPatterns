using System.Text.Json;
using DesignPatterns.AnimalBuilder;
using DesignPatterns.AnimalFileFormatBuilder;
using DesignPatterns.Animals;

namespace DesignPatterns.AnimalReader;

public class JsonAnimalReadFormat : IAnimalReadFormat
{
    public AbstractAnimal[] Read(string path)
    {
        var rawList = JsonSerializer.Deserialize<List<AnimalDTO>>(File.ReadAllText(path));
        if (rawList == null) return [];

        var animals = new List<AbstractAnimal>();

        foreach (var dto in rawList)
        {
            if (!Enum.TryParse<AnimalType>(dto.Type, out var type))
                continue;

            var animal = AnimalBuilder.AnimalBuilder.Create(type)
                .SetName(dto.Name)
                .SetSound(dto.Sound);

            animals.Add(animal);
        }

        return animals.ToArray();
    }
}