using DesignPatterns.EchoMethod;

namespace DesignPatterns.Homework1.EchoMethod;

public class FileEchoMethod : AbstractEchoMethod
{
    private static FileEchoMethod? _instance = null;
    public static FileEchoMethod Instance => _instance ??= new FileEchoMethod();
    
    private FileEchoMethod() { }
    
    public override void Echo(string message)
    {
        File.AppendAllText("EchoFile.txt", message + '\n');
    }
}