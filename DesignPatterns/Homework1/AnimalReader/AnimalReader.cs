using DesignPatterns.Animals;

namespace DesignPatterns.AnimalReader;

public class AnimalReader
{
    private static AnimalReader? _instance = null;
    public static AnimalReader Instance => _instance ??= new AnimalReader();

    public JsonAnimalReadFormat Json { get; }
    public PlainTextAnimalReadFormat PlainText { get; }

    private AnimalReader()
    {
        Json = new JsonAnimalReadFormat();
        PlainText = new PlainTextAnimalReadFormat();
    }
}