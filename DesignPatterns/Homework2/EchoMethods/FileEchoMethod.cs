using DesignPatterns.Homework2.EchoMethods;

namespace DesignPatterns.EchoMethods;

public class FileEchoMethod : IEchoMethod
{
    private const string Path = "echo.txt";

    public void Echo(object obj)
    {
        File.AppendAllText(Path, obj.ToString() + "\n");
    }
}