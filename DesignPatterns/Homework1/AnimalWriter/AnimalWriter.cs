using DesignPatterns.Animals;

namespace DesignPatterns.AnimalWriter;

public class AnimalWriter
{
    private static AnimalWriter? _instance = null;
    public static AnimalWriter Instance => _instance ??= new AnimalWriter();

    public IAnimalWriteFormat? WriteFormat { get; private set; }

    public JsonAnimalWriteFormat Json { get; }
    public PlainTextAnimalWriteFormat PlainText { get; }
    
    private AnimalWriter()
    {
        Json = new JsonAnimalWriteFormat();
        PlainText = new PlainTextAnimalWriteFormat();
    }
}