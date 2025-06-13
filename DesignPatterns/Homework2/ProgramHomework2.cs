namespace DesignPatterns.Homework2;

public static class ProgramHomework2
{
    public static void Run()
    {
        var charactersFacade = new DesignPatterns.CharactersFacade.CharactersFacade();
        charactersFacade.BeginLifetimeScope();
        charactersFacade.Run();
    }
}