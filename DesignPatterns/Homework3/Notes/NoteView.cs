using DesignPatterns.Homework2.EchoMethods;

namespace DesignPatterns.Homework3.Notes;

public class NoteView
{
    private IEchoMethod _echoMethod;

    public NoteView(IEchoMethod echoMethod)
    {
        _echoMethod = echoMethod;
    }

    public void SetEchoMethod(IEchoMethod echoMethod)
    {
        _echoMethod = echoMethod;
    }
    
    public void EchoNote(Note note)
    {
        _echoMethod.Echo(note);
    }
}