using System.Text;

namespace DesignPatterns.Homework3.Notes;

public class Note
{
    public string Title { get; private set; }
    public string Text { get; private set; }
    public DateTime Date { get; private set; }
    public HashSet<string> Tags { get; private set; }

    public Note(string title, string text, DateTime? date = null)
    {
        Title = title;
        Text = text;
        Date = date ?? DateTime.Now;
        Tags = new HashSet<string>();
    }

    public Note AddTags(params string[] tags)
    {
        Tags.UnionWith(tags);
        return this;
    }

    public override string ToString()
    {
        var strBuilder = new StringBuilder($"{Title}\n{Date}\n\n{Text}\n");
        if (Tags.Count > 0)
        {
            strBuilder.Append('\n');
            strBuilder.Append(Tags.Select(t => $"#{t} ").Aggregate((a, b) => $"{a}{b}"));
            strBuilder.Append('\n');
        }
        strBuilder.Append("---------------\n");
        return strBuilder.ToString();
    }
}