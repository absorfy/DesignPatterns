using DesignPatterns.Homework4.Contacts;

namespace DesignPatterns.Homework4;

public static class ProgramHomework4
{
    public static void Run()
    {
        var contactController = new ContactController();
        var contact = contactController.CreateContact("Vlad", "+380000", null, "vlad@gmail", "My contact");
        contactController.EchoContacts(contact);
    }
}