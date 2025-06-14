namespace DesignPatterns.Homework3.Notes;

public class NoteController
{
    private readonly NoteView _view;

    public NoteController()
    {
        _view = new NoteView(new EchoMethodFacade());
    }

    public Note CreateNote(string title, string text, DateTime? date = null)
    {
        return new Note(title, text, date);
    }

    public void EchoNotes(params Note[] notes)
    {
        foreach (var note in notes)
        {
            _view.EchoNote(note);
        }
    }
}