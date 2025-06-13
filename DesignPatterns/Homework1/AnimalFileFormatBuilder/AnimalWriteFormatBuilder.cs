using DesignPatterns.AnimalWriter;

namespace DesignPatterns.AnimalFileFormatBuilder;

public static class AnimalWriteFormatBuilder
{
    public static IAnimalWriteFormat Create(AnimalFileFormat fileFormat)
    {
        return fileFormat switch
        {
            AnimalFileFormat.Json => new JsonAnimalWriteFormat(),
            AnimalFileFormat.PlainText => new PlainTextAnimalWriteFormat(),
            _ => throw new ArgumentOutOfRangeException(nameof(fileFormat), fileFormat, null)
        };
    }
}