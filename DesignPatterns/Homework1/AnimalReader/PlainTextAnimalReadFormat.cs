using DesignPatterns.AnimalBuilder;
using DesignPatterns.Animals;

namespace DesignPatterns.AnimalReader;

public class PlainTextAnimalReadFormat : IAnimalReadFormat
{
    public AbstractAnimal[] Read(string path)
    {
        var lines = File.ReadAllLines(path);
        var animals = new List<AbstractAnimal>();

        foreach (var line in lines)
        {
            var parts = line.Split(':', 2);

            if (parts.Length != 2) continue;

            var typeStr = parts[0].Trim();
            if (!Enum.TryParse<AnimalType>(typeStr, out var type)) continue;

            var rest = parts[1];
            var props = rest.Split(',');

            string name = "", sound = "";
            foreach (var prop in props)
            {
                var kv = prop.Split(':');
                if (kv.Length != 2) continue;

                var key = kv[0].Trim().ToLower();
                var value = kv[1].Trim();

                if (key == "name") name = value;
                else if (key == "sound") sound = value;
            }

            var animal = AnimalBuilder.AnimalBuilder.Create(type)
                .SetName(name)
                .SetSound(sound);

            animals.Add(animal);
        }

        return animals.ToArray();
    }
}