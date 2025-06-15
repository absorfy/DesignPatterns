namespace DesignPatterns.Homework4.Contacts;

public class Contact
{
    public string Name { get; }
    public string Phone { get; }
    public string? AltPhone { get; }
    public string Email { get; }
    public string Description { get; }
    
    public Contact(string name, string phone, string? altPhone, string email, string description)
    {
        Name = name;
        Phone = phone;
        AltPhone = altPhone;
        Email = email;
        Description = description;
    }

    public override string ToString()
    {
        return $"- name: {Name}\n- phone: {Phone}\n- alt phone: {AltPhone ?? "None"}\n- email: {Email}\n- description: {Description}\n";
    }
}