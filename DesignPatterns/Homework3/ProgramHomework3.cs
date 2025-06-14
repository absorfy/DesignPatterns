namespace DesignPatterns.Homework3;

using DesignPatterns.Homework3.Notes;
    
public static class ProgramHomework3
{
    public static void Run()
    {
        NoteController noteController = new NoteController();
        
        var note1 = noteController.CreateNote("MyNote", "loremfeojfepjfew f rojf prjf rpojfoprj fporjfw pjrf r")
                .AddTags("note", "check", "new");

        var note2 = noteController.CreateNote("Second note", "fefefffffffff");
        
        noteController.EchoNotes(note1, note2);
    }
}