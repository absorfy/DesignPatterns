using DesignPatterns.AnimalReader;

namespace DesignPatterns.AnimalFileFormatBuilder;

public class AnimalReadFormatBuilder
{
    public static IAnimalReadFormat Create(AnimalFileFormat fileFormat)
    {
        return fileFormat switch
        {
            AnimalFileFormat.Json => new JsonAnimalReadFormat(),
            AnimalFileFormat.PlainText => new PlainTextAnimalReadFormat(),
            _ => throw new ArgumentOutOfRangeException(nameof(fileFormat), fileFormat, null)
        };
    }
}