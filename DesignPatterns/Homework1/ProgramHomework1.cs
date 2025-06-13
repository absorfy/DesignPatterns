using DesignPatterns.AnimalBuilder;
using DesignPatterns.EchoMethods;

namespace DesignPatterns.Homework1;

public class ProgramHomework1
{
    public static void Run()
    {
        var cat = AnimalBuilder.AnimalBuilder.Create(AnimalType.Cat).SetName("Cat");
        var dog = AnimalBuilder.AnimalBuilder.Create(AnimalType.Dog).SetName("Dog");

        cat.EchoName(EchoMethod.ConsoleEchoMethod.Instance);
        cat.EchoSound(EchoMethod.ConsoleEchoMethod.Instance);
        EchoMethod.FileEchoMethod.Instance.Echo(dog);

        AnimalWriter.AnimalWriter.Instance.Json.Write("CatAndDog.json", cat, dog);
        AnimalWriter.AnimalWriter.Instance.PlainText.Write("CatAndDog.txt", cat, dog);

        EchoMethod.ConsoleEchoMethod.Instance.Echo(AnimalReader.AnimalReader.Instance.PlainText.Read("CatAndDog.txt"));
        EchoMethod.ConsoleEchoMethod.Instance.Echo(AnimalReader.AnimalReader.Instance.Json.Read("CatAndDog.json"));
    }
}